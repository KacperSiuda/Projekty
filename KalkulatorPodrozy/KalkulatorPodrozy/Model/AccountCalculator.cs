using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorPodrozy.Model
{
    public class AccountCalculator
    {
        public double Rate { get; set; }
        public double AmountOwned(double milesTraveled, double reimburseRate)
        {
            double amount = milesTraveled *= reimburseRate;
            return amount;
        }
    }
}
