using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public double BaseSalari { get; set; }
        public DateTime BirthDate { get; set; }
        public Departament Departament { get; set; }
        public ICollection<SalesRecord> Sellers { get; set; } = new List<SalesRecord>();

        public Seller()
        {

        }

        public Seller(int id, string name, string email, double baseSalari, DateTime birthDate, Departament departament)
        {
            Id = id;
            Name = name;
            Email = email;
            BaseSalari = baseSalari;
            BirthDate = birthDate;
            Departament = departament;
        }

        public void AddSales(SalesRecord sr)
        {
            Sellers.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {
            Sellers.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime Final)
        {
            return Sellers.Where(sr => sr.Date >= initial && sr.Date <= Final).Sum(sr => sr.Amount);
        }
    }
}
