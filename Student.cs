using System.ComponentModel.DataAnnotations;
namespace mentoring
{
    public class Student
    {
        public int Id { get; set; } 
        [MaxLength(100)]
        public string Name { get; set; }
        public virtual Instituition Instituition { get; set; }        
    }
}