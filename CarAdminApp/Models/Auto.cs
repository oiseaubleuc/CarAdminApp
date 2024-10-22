using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAdminApp.Models
{
    public class Auto
    {
        public string Merk { get; set; }
        public string Model { get; set; }
        public decimal Prijs { get; set; }

        public Auto(string merk, string model, decimal prijs)
        {
            Merk = merk;
            Model = model;
            Prijs = prijs;
        }
    }
}