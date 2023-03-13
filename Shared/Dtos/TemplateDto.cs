namespace LexiconLMSBlazor.Shared.Dtos
{
    public class TemplateDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public DateTime StartDate { get; set; }

        //public DateTime EndDate { get; set; }
        //public string TypeName { get; set; } = string.Empty;
        //public string ModuleName { get; set; }

    }
}
