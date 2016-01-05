using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartRacingSimulator.Models
{
    public class Bet
    {
        //Class fields//
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription()
        {
            return "";
        }
        public int PayOut(int Winner)
        {
            return 0;
        }

    }
}
