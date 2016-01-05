using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartRacingSimulator.Models
{
    public class Guy
    {
        //Guy Class fields//
        public string Name;
        public Bet MyBet;
        public int Cash;

        //GUI Components variable//
        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels()
        {

        }
        public void ClearBet()
        {

        }
        public bool PlaceBet(int Amount, int DogToWin)
        {
            return false;
        }
        public void Collect(int Winner)
        {

        }
    }
}
