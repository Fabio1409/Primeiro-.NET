
using PrimeiroDOTNET.Models;
using PrimeiroDOTNET.Models.Enums;

namespace PrimeiroDOTNET.Data
{
    public class SeedingService
    {
        private PrimeiroDOTNETContext _context;

        public SeedingService(PrimeiroDOTNETContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            _context.Database.EnsureCreated();
            if (_context.Departament.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; // DB has been seeded
            }
            Departament d1 = new Departament(1, "Computers");
            Departament d2 = new Departament(2, "Electronics");
            Departament d3 = new Departament(3, "Fashion");
            Departament d4 = new Departament(4, "Books");


            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, d2);
            Seller s3 = new Seller(3, "Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, d1);
            Seller s4 = new Seller(4, "Marta Red", "marta@gmail.com", new DateTime(1998, 4, 21), 1000.0, d4);
            Seller s5 = new Seller(5, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, d3);
            Seller s6 = new Seller(6, "Alex Pink", "marta@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);

            SellerRecord r1 = new SellerRecord(1, new DateTime(2018, 09, 25), 11000.0, Models.Enums.SellerStatus.Billed, s1);
            SellerRecord r2 = new SellerRecord(2, new DateTime(2018, 09, 4), 7000.0, Models.Enums.SellerStatus.Billed, s5);
            SellerRecord r3 = new SellerRecord(3, new DateTime(2018, 09, 13), 4000.0, Models.Enums.SellerStatus.Canceled, s4);
            SellerRecord r4 = new SellerRecord(4, new DateTime(2018, 09, 1), 8000.0, Models.Enums.SellerStatus.Billed, s1);
            SellerRecord r5 = new SellerRecord(5, new DateTime(2018, 09, 21), 3000.0, Models.Enums.SellerStatus.Billed, s3);
            SellerRecord r6 = new SellerRecord(6, new DateTime(2018, 09, 15), 2000.0, Models.Enums.SellerStatus.Billed, s1);
            SellerRecord r7 = new SellerRecord(7, new DateTime(2018, 09, 28), 13000.0, Models.Enums.SellerStatus.Billed, s2);
            SellerRecord r8 = new SellerRecord(8, new DateTime(2018, 09, 11), 4000.0, Models.Enums.SellerStatus.Billed, s4);
            SellerRecord r9 = new SellerRecord(9, new DateTime(2018, 09, 14), 11000.0, Models.Enums.SellerStatus.Pending, s6);
            SellerRecord r10 = new SellerRecord(10, new DateTime(2018, 09, 7), 9000.0, Models.Enums.SellerStatus.Billed, s6);
            SellerRecord r11 = new SellerRecord(11, new DateTime(2018, 09, 13), 6000.0, Models.Enums.SellerStatus.Billed, s2);
            SellerRecord r12 = new SellerRecord(12, new DateTime(2018, 09, 25), 7000.0, Models.Enums.SellerStatus.Pending, s3);
            SellerRecord r13 = new SellerRecord(13, new DateTime(2018, 09, 29), 10000.0, Models.Enums.SellerStatus.Billed, s4);
            SellerRecord r14 = new SellerRecord(14, new DateTime(2018, 09, 4), 3000.0, Models.Enums.SellerStatus.Billed, s5);
            SellerRecord r15 = new SellerRecord(15, new DateTime(2018, 09, 12), 4000.0, Models.Enums.SellerStatus.Billed, s1);
            SellerRecord r16 = new SellerRecord(16, new DateTime(2018, 10, 5), 2000.0, Models.Enums.SellerStatus.Billed, s4);
            SellerRecord r17 = new SellerRecord(17, new DateTime(2018, 10, 1), 12000.0, Models.Enums.SellerStatus.Billed, s1);
            SellerRecord r18 = new SellerRecord(18, new DateTime(2018, 10, 24), 6000.0, Models.Enums.SellerStatus.Billed, s3);
            SellerRecord r19 = new SellerRecord(19, new DateTime(2018, 10, 22), 8000.0, Models.Enums.SellerStatus.Billed, s5);
            SellerRecord r20 = new SellerRecord(20, new DateTime(2018, 10, 15), 8000.0, Models.Enums.SellerStatus.Billed, s6);
            SellerRecord r21 = new SellerRecord(21, new DateTime(2018, 10, 17), 9000.0, Models.Enums.SellerStatus.Billed, s2);
            SellerRecord r22 = new SellerRecord(22, new DateTime(2018, 10, 24), 4000.0, Models.Enums.SellerStatus.Billed, s4);
            SellerRecord r23 = new SellerRecord(23, new DateTime(2018, 10, 19), 11000.0, Models.Enums.SellerStatus.Canceled, s2);
            SellerRecord r24 = new SellerRecord(24, new DateTime(2018, 10, 12), 8000.0, Models.Enums.SellerStatus.Billed, s5);
            SellerRecord r25 = new SellerRecord(25, new DateTime(2018, 10, 31), 7000.0, Models.Enums.SellerStatus.Billed, s3);
            SellerRecord r26 = new SellerRecord(26, new DateTime(2018, 10, 6), 5000.0, Models.Enums.SellerStatus.Billed, s4);
            SellerRecord r27 = new SellerRecord(27, new DateTime(2018, 10, 13), 9000.0, Models.Enums.SellerStatus.Pending, s1);
            SellerRecord r28 = new SellerRecord(28, new DateTime(2018, 10, 7), 4000.0, Models.Enums.SellerStatus.Billed, s3);
            SellerRecord r29 = new SellerRecord(29, new DateTime(2018, 10, 23), 12000.0, Models.Enums.SellerStatus.Billed, s5);
            SellerRecord r30 = new SellerRecord(30, new DateTime(2018, 10, 12), 5000.0, Models.Enums.SellerStatus.Billed, s2);

            _context.Departament.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecord.AddRange
                (
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
                );

            _context.SaveChanges();
        }
    }
}
