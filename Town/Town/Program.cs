using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Town
{
    class Program
    {
        static void Main(string[] args)
        {
            List<House> houses = new List<House>();
            houses.Add(new House() { Name = "casauno" });
            houses.Add(new House() { Name = "casados" });

            List<Bank> banks = new List<Bank>();
            banks.Add(new Bank() { Name = "Suntrust" });
            banks.Add(new Bank() { Name = "Wells Fargo" });

            List<School> schools = new List<School>();
            banks.Add(new School() { Name = "CCHS" });
            banks.Add(new School() { Name = "ELHS" });
        }

    }
}
