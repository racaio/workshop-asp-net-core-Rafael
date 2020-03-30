using System.Linq;
using System;
using System.Collections.Generic;

namespace RafaelAppication3.Models
{
    public class Department
    {

        public  int Id { get; set; }
        public string  Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>(); //Icollection coleçao generica serve para fazer um tipo de lista ou
        // conjunto. Ja feita a instanciação  = New // Poi um departmento possui uma lista ou conjunto de vendedores.
        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller)
        {

            Sellers.Add(seller);
        }

        public double TotalSeller(DateTime initial, DateTime final) {

            return Sellers.Sum(seller => seller.TotalSales(initial, final));//pego o total de vendas de cada vendedor dentro do perioso e por fim somo tudo(Seller.Sum)
        }
    }
}
