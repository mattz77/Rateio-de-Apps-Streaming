using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService (SalesWebMvcContext context)
            {
            _context = context;
            }

            public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())


            {
                return; //DB has been seeded
            }


            Department d1 = new Department(1, "computers");
            Department d2 = new Department(2, "electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");


            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 04, 21), 1000.0, d1);
            Seller s2 = new Seller(2 ,"Carlos Eduardo", "carlos@gmail.com", new DateTime(1996, 05, 22), 1500.0, d3);
            Seller s3 = new Seller(3, "Fernando Almeida", "fernando@gmail.com", new DateTime(2000, 05, 07), 3000.0, d2);
            Seller s4 = new Seller(4, "Alberto Dias", "alberto@gmail.com", new DateTime(1986, 11, 12), 1800.0, d4);
            Seller s5 = new Seller(5, "Fabricio Silva", "fabricio@gmail.com", new DateTime(1999, 05, 04), 1700.0, d4);
            Seller s6 = new Seller(6, "Afonso Fernandes", "afonso@gmail.com", new DateTime(1976, 06, 24), 4500.0, d1);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 09, 11), 5000.0, SaleStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2019, 05, 19), 7000.0, SaleStatus.Cancelled, s4);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2019, 07, 25), 2000.0, SaleStatus.Pending, s6);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2020, 06, 21), 5600.0, SaleStatus.Billed, s6);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2019, 07, 14), 4200.0, SaleStatus.Pending, s3);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2017, 03, 12), 6400.0, SaleStatus.Billed, s5);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2017, 02, 04), 2200.0, SaleStatus.Cancelled,s1);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2016, 10, 17), 7200.0, SaleStatus.Billed, s4);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2018, 11, 16), 4300.0, SaleStatus.Pending, s3);

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9,r10);


            _context.SaveChanges();
        }

    }
}
