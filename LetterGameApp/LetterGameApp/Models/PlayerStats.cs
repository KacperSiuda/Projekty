using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterGameApp.Models
{
    public class PlayerStats
    {
        public string PlayerName;
        public int Total = 0;
        public int Missed = 0;
        public int Correct = 0;
        public double Accuracy = 0;

        public void Update(bool correctKey)
        {
            Total++;
            if (!correctKey)
            {
                Missed++;
            }
            else
            {
                Correct++;
            }
            Accuracy = (Correct/Total);
        }
    }
}
