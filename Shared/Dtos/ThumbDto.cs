namespace LexiconLMSBlazor.Shared.Dtos
{
    public class ThumbDto
    {
        public int Id { get; set; }

        public bool IsLike { get; set; }

        public string Name { get; set; } = string.Empty;

        public string? Id4User { get; set; }

        public int Id4Thread { get; set; }
    }
}

