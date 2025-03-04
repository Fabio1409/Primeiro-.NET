using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrimeiroDOTNET.Models;

namespace PrimeiroDOTNET.Data
{
    public class PrimeiroDOTNETContext : DbContext
    {
        public PrimeiroDOTNETContext(DbContextOptions<PrimeiroDOTNETContext> options): base(options) 
        {
        
        }
        public DbSet<Departament> Departament { get; set; } = default!;
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SellerRecord> SalesRecord { get; set; }
    }
}
