using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAdminApp.Models
{
    public class Klant
    {
        public string Naam { get; set; }
        public string Email { get; set; }
        public string Telefoonnummer { get; set; }

        public Klant(string naam, string email, string telefoonnummer)
        {
            Naam = naam;
            Email = email;
            Telefoonnummer = telefoonnummer;
        }
    }
}
