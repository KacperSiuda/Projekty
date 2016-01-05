using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChartRacingSimulator.Models;

namespace ChartRacingSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        Greyhound[] greyhound = new Greyhound[4];
        Guy[] guy = new Guy[3];

        private void ToggleChart(int index,PictureBox pictureBox)
        {
            
            if (greyhound[index] == null)
            {
                greyhound[index] = new Greyhound();
                greyhound[index].MyPictureBox = pictureBox;
            }
            else
            {
                greyhound[index] = null;
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            ToggleChart(0, pictureBox2);
            ToggleChart(1, pictureBox3);
            ToggleChart(2, pictureBox4);
            ToggleChart(3, pictureBox5);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            for(int i=0; i <= 3; i++)
            {
                if(greyhound != null)
                {
                    greyhound[i].Run();
                }
            }
        }
    }
}
