using System.ComponentModel.DataAnnotations;
using System;

namespace Nota10.Models
{
    public class Student
    {
        public int Id { get; set; } 
        [MaxLength(100)]
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int ClassroomId { get; set; }
        public virtual Classroom Classroom { get; set; }                
    }
}