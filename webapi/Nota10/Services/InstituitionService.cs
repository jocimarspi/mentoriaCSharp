using System.Collections.Generic;
using Nota10.Models;
using System.Linq;
using nota10.data;

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
    }
}