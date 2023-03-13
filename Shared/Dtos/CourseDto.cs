namespace LexiconLMSBlazor.Shared.Dtos
{
    public class CourseDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        // Enumerable Type
        //public ICollection<Module> Modules { get; set; } = new List<Module>();

        //public ICollection<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();
    }
}

