using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Henger
    {
        public double magassag;
        public double sugar;
        private static int szuletesSzamlalo = 0;

        public Henger(double magassag, double sugar)
        {
            this.magassag = magassag;
            this.sugar = sugar;
            szuletesSzamlalo += 1;
        }

        public double Terfogat()
        {
            return Math.PI * Math.Pow(sugar,2) *magassag;
        }

        public string ToString()
        {
            return $"térfogat:{Terfogat()}; sugár:{sugar}; magasság:{magassag}";
        }

        public double GetMagassag { get => magassag; }
        public double GetSugar { get => sugar;  }
        public static int SzuletesSzamlalo { get => szuletesSzamlalo; }
    }
    internal class TomorHenger : Henger
    {
        private double fajsuly;

        public TomorHenger(double sugar, double magassag) : base(sugar, magassag)
        {
            this.fajsuly = 7.87;
        }
        public TomorHenger(double sugar, double magassag, double fajsuly) : base(sugar, magassag)
        {
            this.fajsuly = fajsuly;
        }

        public string ToString()
        {
            return $"térfogat:{Terfogat()}; sugár:{sugar}; magasság:{magassag}; fajsúly:{fajsuly}";
        }

        public double GetFajsuly { get => fajsuly; }
    }
    internal class Cso : Henger
    {
        private double falVastagság;

        
        public Cso(double sugar, double magassag, double falVastagság) : base(sugar, magassag)
        {
            this.falVastagság = falVastagság;
        }

        public double Terfogat()
        {
            return Math.PI * Math.Pow((sugar - falVastagság), 2) * magassag;
        }

        public string ToString()
        {
            return $"térfogat:{Terfogat()}; sugár:{sugar}; magasság:{magassag}; falvastagság:{falVastagság}";
        }

        public double GetFalVastagság { get => falVastagság; }
    }
}
