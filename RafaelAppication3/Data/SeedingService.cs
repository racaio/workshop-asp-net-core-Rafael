using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RafaelAppication3.Models;

namespace RafaelAppication3.Data
{
    public class SeedingService
    {
        private RafaelAppication3Context _context;

        public SeedingService(RafaelAppication3Context context)
        {

            _context = context; //meu context da Classe (_contexxt) vai receber o contet que chegou como argumento(context;)
        }

        public void Seed()
        {
            if (_context.Department.Any() || //A opreção Any do linq, vai textar se ja existe regitro na minha tabela do banco
               _context.Seller.Any() ||
               _context.SalesRecord.Any())
            {
                return; //DB has Beem Seeded = Banco de Dados ja populado/Possui dados
            }

            Department d1 = new Department { Name = "Eletronics" };
            Department d2 = new Department { Name = "Moda" };
            Department d3 = new Department { Name = "Atesanato" };
            Department d4 = new Department { Name = "Comercial" };

            Seller s1 = new Seller { Name = "Rafael", Email = "Rafae@gmail.com", BirthDate= new DateTime(1998, 04, 21), BaseSalary = 30000.0, Department = d1 };
            Seller s2 = new Seller { Name = "Leticia", Email = "Rafae@gmail.com", BirthDate = new DateTime(1998, 04, 21), BaseSalary = 20000.0, Department = d2 };
            Seller s3 = new Seller { Name = "Wilma", Email = "Rafae@gmail.com", BirthDate = new DateTime(1998, 04, 21), BaseSalary = 10000.0, Department = d3 };
            Seller s4 = new Seller { Name = "Graziele", Email = "Rafae@gmail.com", BirthDate = new DateTime(1998, 04, 21), BaseSalary = 10000.0, Department = d4 };

            SalesRecord sr1 = new SalesRecord {Date = new DateTime(2018, 03, 01), Amount = 300000.0, Status =  Models.Enuns.SaleStatus.Billed, Seller = s1};
            SalesRecord sr2 = new SalesRecord {Date = new DateTime(2018, 03, 01), Amount = 200000.0, Status = Models.Enuns.SaleStatus.Billed, Seller = s2 };
            SalesRecord sr3 = new SalesRecord {Date = new DateTime(2018, 03, 01), Amount = 100000.0, Status = Models.Enuns.SaleStatus.Billed, Seller = s3 };
            SalesRecord sr4 = new SalesRecord {Date = new DateTime(2018, 03, 01), Amount = 100000.0, Status = Models.Enuns.SaleStatus.Billed, Seller = s4 };

            _context.Department.AddRange(d1,d2,d3,d4);   //AddRange permit inserir varios objetos de uma unida vez;
            _context.Seller.AddRange(s1, s2, s3, s4);
            _context.SalesRecord.AddRange(sr1, sr2, sr3, sr4);

            _context.SaveChanges();//salava e confirmar as alteraçoes no bando de dados
        }
    }
}
