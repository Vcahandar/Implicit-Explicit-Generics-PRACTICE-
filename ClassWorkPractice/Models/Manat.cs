using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkPractice.Models
{
    public class Manat
    {
        public double AZN { get; set; }
        public Manat(double azn)
        {
            AZN = azn;
        }

        public static implicit operator Dollar(Manat manat)
        {
            return new Dollar(manat.AZN/1.7);
        }
    }
}
