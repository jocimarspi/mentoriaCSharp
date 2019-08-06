using System.ComponentModel.DataAnnotations;
using Nota10.Services;

namespace Nota10.Models 
{
    public class Instituition 
    {
        public int Id { get; set; }
                
        [MaxLength(100)]
        public string Name { get; set; }        
    }
}