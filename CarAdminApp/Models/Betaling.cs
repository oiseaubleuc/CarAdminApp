using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAdminApp.Models
{
    public class Betaling
    {
        public decimal Bedrag { get; set; }
        public DateTime Datum { get; set; }

        public Betaling(decimal bedrag, DateTime datum)
        {
            Bedrag = bedrag;
            Datum = datum;
        }
    }
}
