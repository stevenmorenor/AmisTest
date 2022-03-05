using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmisTest.Models
{
    [Table("Questions")]
    public class Question
    {
        [Key]
        public Guid QuestionId { get; set; } = Guid.NewGuid();
        public string Description { get; set; }
        public virtual ICollection<Form> Forms { get; set; }
        public virtual ICollection<Person> People { get; set; }
    }
}
