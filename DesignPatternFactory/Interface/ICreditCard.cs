using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFactory.Interface
{
    public interface ICreditCard
    {
        string GetCardType();

        int GetCardLimit();

        int GetAnnualCharge();
    }
}
