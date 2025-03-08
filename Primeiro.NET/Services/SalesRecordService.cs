using Microsoft.EntityFrameworkCore;
using PrimeiroDOTNET.Data;
using PrimeiroDOTNET.Models;

namespace PrimeiroDOTNET.Services
{
    public class SalesRecordService
    {
        private readonly PrimeiroDOTNETContext _context;

        public SalesRecordService(PrimeiroDOTNETContext context)
        {
            _context = context;
        }
        public async Task<List< IGrouping<Departament,SellerRecord>>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return await result
              .Include(x => x.Seller)
              .Include(x => x.Seller.Departament)
              .OrderByDescending(x => x.Date)
              .GroupBy(x => x.Seller.Departament)
              .ToListAsync();
        }

        public async Task<List<IGrouping<Departament, SellerRecord>>> FindByDateGroupingAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return await result
              .Include(x => x.Seller)
              .Include(x => x.Seller.Departament)
              .OrderByDescending(x => x.Date)
               .GroupBy(x => x.Seller.Departament)
              .ToListAsync();
        }

        internal async Task<string?> FindByDateAync(DateTime? minDate, DateTime? maxDate)
        {
            throw new NotImplementedException();
        }
    }
}
