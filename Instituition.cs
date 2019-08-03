using System.ComponentModel.DataAnnotations;
namespace mentoring 
{
    public class Instituition 
    {
        public int Id { get; set; }
                
        [MaxLength(100)]
        public string Name { get; set; }        
    }
}