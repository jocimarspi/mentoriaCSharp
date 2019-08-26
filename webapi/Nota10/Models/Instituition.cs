using System.ComponentModel.DataAnnotations;

namespace Nota10.Models 
{
    public class Instituition 
    {
        public int Id { get; set; }                
        [MaxLength(100)]
        public string Name { get; set; }        
    }
}