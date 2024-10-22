using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAdminApp.Models;

namespace CarAdminApp.Services
{
    public class AutoService
    {
        private List<Auto> autos = new List<Auto>();

        public void VoegAutoToe(Auto auto)
        {
            autos.Add(auto);
        }

        public List<Auto> GetAutos()
        {
            return autos;
        }
    }
}
