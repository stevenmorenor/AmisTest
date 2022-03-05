using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmisTest.Models
{
    [Table("People")]
    public class Person
    {
        [Key]
        public Guid PersonId { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string BornPlace { get; set; }
        public string Address { get; set; }
        public bool Genrer { get; set; }
        public virtual ICollection<Form> Forms { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}
