using PrimeiroDOTNET.Models;

namespace PrimeiroDOTNET.Services
{
    public class SellerService
    {
        private readonly Data.PrimeiroDOTNETContext _context;

        public SellerService(Data.PrimeiroDOTNETContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
            
        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
