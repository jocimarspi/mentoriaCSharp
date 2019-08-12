using System.Collections.Generic;
using Nota10.Models;
using System.Linq;
using Nota10.Data;

namespace Nota10.Services
{
    public class InstituitionService
    {
        private readonly Nota10Context _context;

        public InstituitionService(Nota10Context context)
        {
            _context = context;
        }

        public List<Instituition> All()
        {
            return _context.Instituitions.OrderBy(i => i.Name).ToList();    
        }
        
        public Instituition FindById(int id)
        {
            var resultado = _context.Instituitions.Where(i => i.Id == id);

            if (!resultado.Any())
            {
                return null;
            }

            return resultado.OrderBy(i => i.Name).First();
        }

        public List<Instituition> FindByName(string partialName)
        {
            return _context.Instituitions
                .Where(
                    i => i.Name.ToLower().Contains(partialName.ToLower())
                    )
                .OrderBy(i => i.Name).ToList();    
        }

        public void Save(Instituition instituition)
        {
            if (instituition == null) {
                return;
            }

            _context.Instituitions.Add(instituition);
            _context.SaveChanges();
        } 

        public void DeleteById(int id){
            _context.Remove(new Instituition{Id = id});
            _context.SaveChanges();
        }
    }
}