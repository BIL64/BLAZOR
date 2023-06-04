using Bogus;
using LexiconLMSBlazor.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Module = LexiconLMSBlazor.Server.Models.Module;
using Activity = LexiconLMSBlazor.Server.Models.Activity;
using System.Linq.Expressions;

namespace LexiconLMSBlazor.Server.Data // Av Jean-Yves Michel
{
    public class SeedDataUser
    {
        private static RoleManager<IdentityRole> roleManager = default!;
        private static UserManager<ApplicationUser> userManager = default!;

        public static async Task InitAsync(ApplicationDbContext db, IServiceProvider services)
        {
            if (await db.Course.AnyAsync()) return;

            roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
            ArgumentNullException.ThrowIfNull(roleManager);

            userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
            ArgumentNullException.ThrowIfNull(userManager);

            var teacherEmail = "teacher@lms.se";

            var teacherPassword = "Pass@Word00!";
            var studentPassword = "PassStudent@Word00!";

            var roleNames = new[] { "Teacher", "Student" };

            await AddRolesAsync(roleNames); //OK

            var teacher = await AddTeacherAsync(teacherEmail, teacherPassword);

            await AddToRolesAsync(teacher, roleNames); //OK

            var register = GenerateRegClass(); //BL

            var activityTypes = GenerateActivityTypes(); //OK

            var courses = GenerateCourses(10); //OK

            var rnd = new Random();

            //To have only one Course/Student
            foreach (var course in courses)
            {
                var students = GenerateStudents(rnd.Next(15, 25)); //returns random integers >= 15 and < 25
                await AddStudentsAsync(students, "Student", studentPassword);
                course.Users = students;
            }

            db.Add(register); //BL
            db.AddRange(activityTypes); //OK

            await db.AddRangeAsync(courses); //OK
            await db.SaveChangesAsync();
        }

        private static Register GenerateRegClass()
        {
            var reg = new Register { RegClass = "d-block" };
            return reg;
        }

        private static List<ActivityType> GenerateActivityTypes()
        {
            var list = new List<ActivityType>
            {
                new ActivityType{ Name = "Assignments"},
                new ActivityType{ Name = "E-learning sessions"},
                new ActivityType{ Name = "Training sessions"},
                new ActivityType{ Name = "Lectures"},
                new ActivityType{ Name = "Other"},
            };
            return list;
        }

        private static async Task AddRolesAsync(string[] roleNames)
        {
            foreach (var roleName in roleNames)
            {
                if (await roleManager.RoleExistsAsync(roleName)) continue;
                var role = new IdentityRole { Name = roleName };
                var result = await roleManager.CreateAsync(role);

                if (!result.Succeeded) throw new Exception(string.Join("\n", result.Errors));
            }
        }

        private static List<Activity> GenerateActivities(int nrOfActivities)
        {
            var faker = new Faker("sv");
            var activities = new List<Activity>();

            for (int i = 0; i < nrOfActivities; i++)
            {
                var temp = new Activity
                {
                    Name = faker.Company.CatchPhrase(),
                    Description = faker.Hacker.Verb(),
                    StartDate = faker.Date.Past(),
                    EndDate = faker.Date.Recent(),
                    ActivityTypeId = faker.Random.Number(1, 5)
                };
                activities.Add(temp);
            }
            return activities;
        }

        private static IEnumerable<Course> GenerateCourses(int nrOfCourses)
        {
            var courses = new List<Course>();
            var faker = new Faker("sv");
            var rnd = new Random();

            for (int i = 0; i < nrOfCourses; i++)
            {
                var modules = new List<Module>();

                int rak = rnd.Next(1, 8);
                for (int j = 0; j < rak; j++)
                {
                    modules.Add(new Module
                    {
                        Name = faker.Company.CatchPhrase(),
                        Description = faker.Hacker.Verb(),
                        StartDate = faker.Date.Past(),
                        EndDate = faker.Date.Recent(),
                        Activities = GenerateActivities(4) //Generate Activities 4 Ok
                    });

                }

                var temp = new Course
                {
                    Name = faker.Company.CatchPhrase(),
                    Description = faker.Hacker.Verb(),
                    StartDate = faker.Date.Past(),
                    EndDate = faker.Date.Recent(),
                    Modules = modules,

                };
                courses.Add(temp);
            }
            return courses;
        }

        //Students Part Added in version 2
        private static List<ApplicationUser> GenerateStudents(int nrOfStudents)
        {
            var students = new List<ApplicationUser>();
            var faker = new Faker("sv");

            for (int i = 0; i < nrOfStudents; i++)
            {
                var fName = faker.Name.FirstName();
                var lName = faker.Name.LastName();
                var email = faker.Internet.Email(fName, lName, "lexicon.sv"); // SWE!
                var phoneNumber = faker.Phone.PhoneNumberFormat();

                var student = new ApplicationUser
                {
                    FirstName = fName,
                    LastName = lName,
                    Email = email,
                    UserName = email,
                    EmailConfirmed = true,
                    PhoneNumber = phoneNumber,
                    PhoneNumberConfirmed = true
                };

                students.Add(student);
            }
            return students;
        }

        private static async Task AddToRolesAsync(ApplicationUser teacher, string[] roleNames)
        {
            foreach (var role in roleNames)
            {
                if (await userManager.IsInRoleAsync(teacher, role)) continue;
                var result = await userManager.AddToRoleAsync(teacher, role);
                if (!result.Succeeded) throw new Exception(string.Join("\n", result.Errors));
            }
        }

        private static async Task<ApplicationUser> AddTeacherAsync(string teacherEmail, string teacherPW)
        {
            var faker = new Faker("sv");

            var findTeacherByEmail = await userManager.FindByEmailAsync(teacherEmail);
            if (findTeacherByEmail != null) return null!;

            var phoneNumber = faker.Phone.PhoneNumberFormat();

            var teacher = new ApplicationUser
            {
                FirstName = "Jane",
                LastName = "Doe",
                UserName = teacherEmail,
                Email = teacherEmail,
                EmailConfirmed = true,
                PhoneNumber = phoneNumber,
                PhoneNumberConfirmed = true
            };

            var result = await userManager.CreateAsync(teacher, teacherPW);
            if (!result.Succeeded) throw new Exception(string.Join("\n", result.Errors));

            return teacher;
        }

        private static async Task AddStudentsAsync(List<ApplicationUser> students, string role, string password)
        {
            foreach (var student in students)
            {

                if (student.Email is not null)
                {
                    var findStudentByEmail = await userManager.FindByEmailAsync(student.Email);
                    if (findStudentByEmail != null) return;
                }

                var result = await userManager.CreateAsync(student, password);
                if (!result.Succeeded) throw new Exception(string.Join("\n", result.Errors));

                await userManager.AddToRoleAsync(student, role);
            }
        }
    }
}