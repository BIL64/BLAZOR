using Bogus;
using LexiconLMSBlazor.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LexiconLMSBlazor.Server.Data
{
    public class SeedData
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


            var roleNames = new[] { "Teacher", "Student" };
            await AddRolesAsync(roleNames); //OK

            var activityTypes = GenerateActivityTypes(); //OK

            var courses = GenerateCourses(50); //OK


            db.AddRange(activityTypes);
            db.AddRange(courses);
            await db.SaveChangesAsync();
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

                int rak = rnd.Next(1, 4);
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


    }
}
