using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RafaelAppication3.Models
{
    public class Seller
    {

        public  int Id { get; set; }
        public string Name { get; set; }
        public string Email  { get; set; }
        public  DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();// Icollection Funciona como um forma generica de criar lista
        //nese caso  ja estou efetuando a instanciaç]ao = new LIst<Seller>

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SalesRecord sr)//iriei receber um sr do tipo do meu registro d vendas
        {
            Sales.Add(sr); //irei adicioanr uma benda em minha lista (Icolection) de vendas.
        }

        public void Removesales (SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);//sr talque então jogo minha filtragem, depois efetuo a soma (sr.Amount)
        }
    }
}
