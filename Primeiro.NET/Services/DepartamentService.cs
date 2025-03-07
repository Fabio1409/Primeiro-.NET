using Microsoft.EntityFrameworkCore;
using PrimeiroDOTNET.Models;
namespace PrimeiroDOTNET.Services
{
    public class DepartamentService
    {
        private readonly Data.PrimeiroDOTNETContext _context;

        public DepartamentService(Data.PrimeiroDOTNETContext context)
        {
            _context = context;
        }

        public async Task<List<Departament>> FindAllAsync()
        {
            return await _context.Departament.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
