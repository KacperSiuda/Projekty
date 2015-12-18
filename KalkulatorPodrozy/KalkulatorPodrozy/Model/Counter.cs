using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorPodrozy.Model
{
    public class Counter
    {

        public int StartCounter { get; set; }
        public int FinalCounter { get; set; }

        public double MilesTraveled(int start, int end)
        {
            double traveledMiles = FinalCounter - StartCounter;
            return traveledMiles;
        }
    }
}
