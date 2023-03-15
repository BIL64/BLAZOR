﻿namespace LexiconLMSBlazor.Shared.Dtos
{
    public class CourseDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public IEnumerable<ModuleDto> Modules { get; set; } = new List<ModuleDto>();
    }
}

