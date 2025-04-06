using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternFactory.Interface;

namespace DesignPatternFactory.Implementation
{
    public class Titanium : ICreditCard
    {
        public string GetCardType()
        {
            return "Titanium";
        }

        public int GetCardLimit()
        {
            return 500000;
        }

        public int GetAnnualCharge()
        {
            return 2000;
        }
    }
}
