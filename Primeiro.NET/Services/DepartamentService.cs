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

        public List<Departament> FindAll()
        {
            return _context.Departament.OrderBy(x => x.Name).ToList();
        }
    }
}
