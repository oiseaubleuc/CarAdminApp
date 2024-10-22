using CarAdminApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAdminApp.Services
{
    public class KlantService
    {
        private List<Klant> klanten = new List<Klant>();

        public void VoegKlantToe(Klant klant)
        {
            klanten.Add(klant);
        }

        public List<Klant> GetKlanten()
        {
            return klanten;
        }

        // Voeg hier meer methoden toe voor bewerken of verwijderen van klanten
    }
}