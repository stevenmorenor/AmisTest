using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmisTest.Models
{
    [Table("Forms")]
    public class Form
    {
        [Key]
        public Guid FormId { get; set; } = Guid.NewGuid();
        public Guid QuestionId { get; set; }
        public Guid PersonId { get; set; }
        public string Answer { get; set; }
        public virtual Person Person { get; set; }
        public virtual Question Question { get; set; }
    }
}
