using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartRacingSimulator.Models
{
    public class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLenght;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random MyRandom;

        public bool Run()
        {
            if (Location <= RacetrackLenght)
            {
                
                int distance = MyRandom.Next(1, 4);
                Location = MyPictureBox.Left += distance;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TakeStartingPosition()
        {
            StartingPosition = 0;
        }
    }
}
