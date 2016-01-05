using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LetterGameApp.Models;

namespace LetterGameApp
{
    public partial class MenuWindow : Form
    {
        public PlayerStats player = new PlayerStats();
        
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.PlayerName = textBox1.Text;

            this.InitializeNewWinodw();
            
        }
        private void InitializeNewWinodw()
        {
            var form2 = new Form1(this);
            form2.ShowDialog();
            
        }
    }
}
