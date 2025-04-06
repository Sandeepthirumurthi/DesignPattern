using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternFactory.Interface;

namespace DesignPatternFactory.Implementation
{
    public class MoneyBack : ICreditCard
    {
        public string GetCardType()
        {
            return "MoneyBack";
        }

        public int GetCardLimit()
        {
            return 150000;
        }

        public int GetAnnualCharge()
        {
            return 500;
        }
    }
}
