using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesAppSystem.Models;
using SalesAppSystem.Models.Enums;

namespace SalesAppSystem.Data
{
    public class SeedingService
    {
        private SalesAppSystemContext _context;

        public SeedingService(SalesAppSystemContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; // DB has been seeded
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Cleison Nunes", "cleison@gmail.com", new DateTime(1999, 12, 30), 1000.0, d1);
            Seller s2 = new Seller(2, "Juliana Faria", "juliana@gmail.com", new DateTime(1998, 05, 30), 3500.0, d2);
            Seller s3 = new Seller(3, "Robson Nunes", "robson@gmail.com", new DateTime(2000, 06, 30), 2000.0, d1);
            Seller s4 = new Seller(4, "Erick Nonato", "erick@gmail.com", new DateTime(1956, 07, 30), 4500.0, d4);
            Seller s5 = new Seller(5, "Raul Seixas", "raul@gmail.com", new DateTime(1978, 11, 30), 5000.0, d3);
            Seller s6 = new Seller(6, "Carlos Magno", "magno@gmail.com", new DateTime(2006, 12, 10), 500.0, d2);

              SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s1);
              SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 09, 4), 7000.0, SaleStatus.Billed, s5);
              SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 09, 13), 4000.0, SaleStatus.Canceled, s4);
              SalesRecord r4 = new SalesRecord(4, new DateTime(2018, 09, 1), 8000.0, SaleStatus.Billed, s1);
              SalesRecord r5 = new SalesRecord(5, new DateTime(2018, 09, 21), 3000.0, SaleStatus.Billed, s3);
              SalesRecord r6 = new SalesRecord(6, new DateTime(2018, 09, 15), 2000.0, SaleStatus.Billed, s1);
              SalesRecord r7 = new SalesRecord(7, new DateTime(2018, 09, 28), 13000.0, SaleStatus.Billed, s2);
              SalesRecord r8 = new SalesRecord(8, new DateTime(2018, 09, 11), 4000.0, SaleStatus.Billed, s4);
              SalesRecord r9 = new SalesRecord(9, new DateTime(2018, 09, 14), 11000.0, SaleStatus.Pending, s6);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2018, 09, 7), 9000.0, SaleStatus.Billed, s6);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2018, 09, 13), 6000.0, SaleStatus.Billed, s2);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2018, 09, 25), 7000.0, SaleStatus.Pending, s3);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2018, 09, 29), 10000.0, SaleStatus.Billed, s4);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2018, 09, 4), 3000.0, SaleStatus.Billed, s5);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2018, 09, 12), 4000.0, SaleStatus.Billed, s1);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2018, 10, 5), 2000.0, SaleStatus.Billed, s4);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2018, 10, 1), 12000.0, SaleStatus.Billed, s1);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2018, 10, 24), 6000.0, SaleStatus.Billed, s3);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2018, 10, 22), 8000.0, SaleStatus.Billed, s5);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2018, 10, 15), 8000.0, SaleStatus.Billed, s6);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2018, 10, 17), 9000.0, SaleStatus.Billed, s2);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2018, 10, 24), 4000.0, SaleStatus.Billed, s4);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2018, 10, 19), 11000.0, SaleStatus.Canceled, s2);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2018, 10, 12), 8000.0, SaleStatus.Billed, s5);
            SalesRecord r25 = new SalesRecord(25, new DateTime(2018, 10, 31), 7000.0, SaleStatus.Billed, s3);
            SalesRecord r26 = new SalesRecord(26, new DateTime(2018, 10, 6), 5000.0, SaleStatus.Billed, s4);
            SalesRecord r27 = new SalesRecord(27, new DateTime(2018, 10, 13), 9000.0, SaleStatus.Pending, s1);
            SalesRecord r28 = new SalesRecord(28, new DateTime(2018, 10, 7), 4000.0, SaleStatus.Billed, s3);
            SalesRecord r29 = new SalesRecord(29, new DateTime(2018, 10, 23), 12000.0, SaleStatus.Billed, s5);
            SalesRecord r30 = new SalesRecord(30, new DateTime(2018, 10, 12), 5000.0, SaleStatus.Billed, s2);

            SalesRecord a1 = new SalesRecord(31, new DateTime(2023, 02, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord a2 = new SalesRecord(32, new DateTime(2023, 02, 4), 7000.0, SaleStatus.Billed, s5);
            SalesRecord a3 = new SalesRecord(33, new DateTime(2023, 02, 13), 4000.0, SaleStatus.Canceled, s4);
            SalesRecord a4 = new SalesRecord(34, new DateTime(2023, 02, 1), 8000.0, SaleStatus.Billed, s1);
            SalesRecord a5 = new SalesRecord(35, new DateTime(2023, 02, 21), 3000.0, SaleStatus.Billed, s3);
            SalesRecord a6 = new SalesRecord(36, new DateTime(2023, 02, 15), 2000.0, SaleStatus.Billed, s1);
            SalesRecord a7 = new SalesRecord(37, new DateTime(2023, 02, 28), 13000.0, SaleStatus.Billed, s2);
            SalesRecord a8 = new SalesRecord(38, new DateTime(2023, 02, 11), 4000.0, SaleStatus.Billed, s4);
            SalesRecord a9 = new SalesRecord(39, new DateTime(2023, 03, 14), 11000.0, SaleStatus.Pending, s6);
            SalesRecord a10 = new SalesRecord(40, new DateTime(2023, 03, 7), 9000.0, SaleStatus.Billed, s6);
            SalesRecord a11 = new SalesRecord(59, new DateTime(2023, 03, 13), 6000.0, SaleStatus.Billed, s2);
            SalesRecord a12 = new SalesRecord(41, new DateTime(2023, 03, 25), 7000.0, SaleStatus.Pending, s3);
            SalesRecord a13 = new SalesRecord(42, new DateTime(2023, 04, 29), 10000.0, SaleStatus.Billed, s4);
            SalesRecord a14 = new SalesRecord(43, new DateTime(2023, 04, 4), 3000.0, SaleStatus.Billed, s5);
            SalesRecord a15 = new SalesRecord(44, new DateTime(2023, 04, 12), 4000.0, SaleStatus.Billed, s1);
            SalesRecord a16 = new SalesRecord(45, new DateTime(2023, 04, 5), 2000.0, SaleStatus.Billed, s4);
            SalesRecord a17 = new SalesRecord(46, new DateTime(2023, 04, 1), 12000.0, SaleStatus.Billed, s1);
            SalesRecord a18 = new SalesRecord(47, new DateTime(2023, 04, 24), 6000.0, SaleStatus.Billed, s3);
            SalesRecord a19 = new SalesRecord(48, new DateTime(2023, 06, 22), 8000.0, SaleStatus.Billed, s5);
            SalesRecord a20 = new SalesRecord(49, new DateTime(2023, 06, 15), 8000.0, SaleStatus.Billed, s6);
            SalesRecord a21 = new SalesRecord(50, new DateTime(2023, 06, 17), 9000.0, SaleStatus.Billed, s2);
            SalesRecord a22 = new SalesRecord(60, new DateTime(2023, 06, 24), 4000.0, SaleStatus.Billed, s4);
            SalesRecord a23 = new SalesRecord(51, new DateTime(2023, 06, 19), 11000.0, SaleStatus.Canceled, s2);
            SalesRecord a24 = new SalesRecord(52, new DateTime(2023, 10, 12), 8000.0, SaleStatus.Billed, s5);
            SalesRecord a25 = new SalesRecord(53, new DateTime(2023, 10, 31), 7000.0, SaleStatus.Billed, s3);
            SalesRecord a26 = new SalesRecord(54, new DateTime(2023, 07, 6), 5000.0, SaleStatus.Billed, s4);
            SalesRecord a27 = new SalesRecord(55, new DateTime(2023, 07, 13), 9000.0, SaleStatus.Pending, s1);
            SalesRecord a28 = new SalesRecord(56, new DateTime(2023, 10, 7), 4000.0, SaleStatus.Billed, s3);
            SalesRecord a29 = new SalesRecord(57, new DateTime(2023, 10, 23), 12000.0, SaleStatus.Billed, s5);
            SalesRecord a30 = new SalesRecord(58, new DateTime(2023, 11, 12), 5000.0, SaleStatus.Billed, s2);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(
                r1,
                r2,
                r3,
                r4,
                r5,
                r6,
                r7,
                r8,
                r9,
                r10,
                r11,
                r12,
                r13,
                r14,
                r15,
                r16,
                r17,
                r18,
                r19,
                r20,
                r21,
                r22,
                r23,
                r24,
                r25,
                r26,
                r27,
                r28,
                r29,
                r30,
                a1,
                a2,
                a3,
                a4,
                a5,
                a6,
                a7,
                a8,
                a9,
                a10,
                a11,
                a12,
                a13,
                a14,
                a15,
                a16,
                a17,
                a18,
                a19,
                a20,
                a21,
                a22,
                a23,
                a24,
                a25,
                a26,
                a27,
                a28,
                a29,
                a30
                );

            _context.SaveChanges();
        }
    }
}
