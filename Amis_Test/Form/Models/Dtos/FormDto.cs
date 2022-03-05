using System;

namespace AmisTest.Models.Dtos
{
    public class FormDto
    {
        public Guid FormId { get; set; }
        public string Question { get; set; }
        public string Name { get; set; }
        public string Answer { get; set; }
    }
}
