using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KalkulatorPodrozy.Model;

namespace KalkulatorPodrozy
{
    public partial class Form1 : Form
    {
        private Counter counter;
        private AccountCalculator account;
        public Form1()
        {
            InitializeComponent();
            counter = new Counter();
            account = new AccountCalculator();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter.StartCounter = (int) numericUpDown1.Value;
            counter.FinalCounter = (int) numericUpDown2.Value;
            if (counter.StartCounter <= counter.FinalCounter)
            {
                label4.Text = account.AmountOwned(counter.MilesTraveled(counter.StartCounter, counter.FinalCounter), 0.55)
                    .
                    ToString(CultureInfo.InvariantCulture) + "zł";
            }
            else
            {
                MessageBox.Show("Początkowy stan licznika musi być mniejszy niż końcowy", "Nie mogę obliczyć odległości");
            }
        }
    }
}
