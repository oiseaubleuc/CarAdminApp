using CarAdminApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAdminApp.Services
{
    public class BetalingService
    {
        private List<Betaling> betalingen = new List<Betaling>();

        public void VoegBetalingToe(Betaling betaling)
        {
            betalingen.Add(betaling);
        }

        public List<Betaling> GetBetalingen()
        {
            return betalingen;
        }

        // Voeg hier meer methoden toe voor bewerken of verwijderen van betalingen
    }
}