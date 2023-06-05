using Bogus;
using LexiconLMSBlazor.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LexiconLMSBlazor.Server.Data // Av Jean-Yves Michel (ombyggd av Björn Lindqvist)
{
    public class SeedDataMax
    {
        private static RoleManager<IdentityRole> roleManager = default!;
        private static UserManager<ApplicationUser> userManager = default!;

        public static async Task InitAsync(ApplicationDbContext db, IServiceProvider services)
        {
            if (await db.Course.AnyAsync()) return; // Hoppar ut om tabellen inte är tom.

            roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
            ArgumentNullException.ThrowIfNull(roleManager);

            userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
            ArgumentNullException.ThrowIfNull(userManager);

            string Title_user = "Student";
            string Title_admin = "Teacher";
            string Password_user = $"Pass{Title_user}@Word00!";
            string Password_admin = $"Pass{Title_admin}@Word00!";
            string Fname_admin = "John";
            string Lname_admin = "Doe";
            string Email_admin = $"{Fname_admin}@{Lname_admin}.se";
            string Phone_admin = "0708-112233";

            await roleManager.CreateAsync(new IdentityRole { Name = Title_user }); // Skapar en roll-titel för användare.

            await roleManager.CreateAsync(new IdentityRole { Name = Title_admin }); // Skapar en roll-titel för administratörer.

            db.Add(new Register { RegClass = "d-block" }); // Iorningsställer registertabellen - ON (besökare kan registrera sig)
            await db.SaveChangesAsync();

            db.AddRange(GenerateActivityTypes()); // Laddar tabellen med aktivitetstyper av fördefinerade typer.
            await db.SaveChangesAsync();

            var courses = GenerateCourses(10); // Laddar tabellen med kurser plus tillhörande moduler och aktiviteter enligt boguspricipen.
            db.AddRange(courses);
            await db.SaveChangesAsync();

            await GenerateUsers(courses, 15, 25, Title_user, Password_user); // Kopplar ett slumptal stycken användare till kurserna enligt bogusprincipen.
            await db.SaveChangesAsync();

            await GenerateAdmin(Fname_admin, Lname_admin, Phone_admin, Title_admin, Email_admin, Password_admin); // Skapar en fördefinerad administratör.
            await db.SaveChangesAsync();
        }

        private static List<ActivityType> GenerateActivityTypes()
        {
            var list = new List<ActivityType> // <-- antalet aktivitetstyper = 5.
            {
                new ActivityType{ Name = "Assignments"},
                new ActivityType{ Name = "E-learning sessions"},
                new ActivityType{ Name = "Training sessions"},
                new ActivityType{ Name = "Lectures"},
                new ActivityType{ Name = "Other"},
            };
            return list;
        }

        private static List<Activity> GenerateActivities(int nrOfActivities)
        {
            var faker = new Faker("sv");
            var activities = new List<Activity>();

            for (int i = 0; i < nrOfActivities; i++)
            {
                var activity = new Activity
                {
                    Name = faker.Company.CatchPhrase(),
                    Description = faker.Hacker.Phrase(),
                    StartDate = faker.Date.Past(),
                    EndDate = faker.Date.Recent(),
                    ActivityTypeId = faker.Random.Number(1, 5) // <-- antalet aktivitetstyper = 5.
                };

                activities.Add(activity);
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

                int nrOfmod = rnd.Next(3, 7); // Slumptal av moduler.
                for (int j = 0; j < nrOfmod; j++)
                {
                    modules.Add(new Module
                    {
                        Name = faker.Company.CatchPhrase(),
                        Description = faker.Hacker.Phrase(),
                        StartDate = faker.Date.Past(),
                        EndDate = faker.Date.Recent(),
                        Activities = GenerateActivities(rnd.Next(2, 6)) // Slumptal av aktiviteter.
                    });

                }

                var course = new Course
                {
                    Name = faker.Company.CatchPhrase(),
                    Description = faker.Hacker.Phrase(),
                    StartDate = faker.Date.Past(),
                    EndDate = faker.Date.Recent(),
                    Modules = modules
                };

                courses.Add(course);
            }
            return courses;
        }

        private static async Task GenerateUsers(IEnumerable<Course> courses, int min, int max, string title, string pass)
        {
            var rnd = new Random();

            foreach (var course in courses)
            {
                var students = GenerateMembers(rnd.Next(min, max));

                foreach (var student in students)
                {
                    await userManager.CreateAsync(student, pass);
                    await userManager.AddToRoleAsync(student, title);
                }
                course.Users = students;
            }
        }

        private static List<ApplicationUser> GenerateMembers(int nrOfMembers)
        {
            var members = new List<ApplicationUser>();
            var faker = new Faker("sv"); // Svenska namn.

            for (int i = 0; i < nrOfMembers; i++)
            {
                var fname = faker.Name.FirstName();
                var lname = faker.Name.LastName();
                var email = faker.Internet.Email(fname, lname, "lexicon.se");
                var phoneNumber = faker.Phone.PhoneNumberFormat();

                var member = new ApplicationUser
                {
                    FirstName = fname,
                    LastName = lname,
                    Email = email,
                    UserName = email,
                    EmailConfirmed = true,
                    PhoneNumber = phoneNumber,
                    PhoneNumberConfirmed = true
                };

                members.Add(member);
            }
            return members;
        }

        private static async Task GenerateAdmin(string fname, string lname, string phone, string title, string email, string pass)
        {
            var admin = new ApplicationUser
            {
                FirstName = fname,
                LastName = lname,
                UserName = email,
                Email = email,
                EmailConfirmed = true,
                PhoneNumber = phone,
                PhoneNumberConfirmed = true
            };

            await userManager.CreateAsync(admin, pass);
            await userManager.AddToRoleAsync(admin, title);
        }
    }
}