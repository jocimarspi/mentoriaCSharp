using System.ComponentModel.DataAnnotations;

namespace Nota10.Models
{
    public class ClassRoom
    {
        public int Id { get; set; }
        
        [MaxLength(100)]
        public string Name { get; set; }
        
        public short SchoolYear { get; set; }

        public virtual Instituition Instituition { get; set; }
    }
}