using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||  _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return;
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1,"Paulo","prpaulo@",new DateTime(1998,4,21),1900,d1);
            Seller s2 = new Seller(2,"Roberto","paulocatnya@",new DateTime(1998,4,21),1900,d2);
            Seller s3 = new Seller(3,"Caetano","prcr@",new DateTime(1998,4,21),1900,d3);


            SalesRecord sr1 = new SalesRecord(1, new DateTime(2019, 4, 15), 500, SaleStatus.PENDING, s1);
            SalesRecord sr2 = new SalesRecord(2, new DateTime(2019, 4, 15), 1500, SaleStatus.BILLED, s2);
            SalesRecord sr3 = new SalesRecord(3, new DateTime(2019, 1, 15), 3500, SaleStatus.CANCELED, s3);
            SalesRecord sr4 = new SalesRecord(4, new DateTime(2018, 4, 15), 2500, SaleStatus.PENDING, s2);

            _context.Department.AddRange(d1,d2,d3,d4);
            _context.Seller.AddRange(s1,s2,s3);
            _context.SalesRecord.AddRange(sr1,sr2,sr3,sr4);

            _context.SaveChanges();


        }


    }
}
