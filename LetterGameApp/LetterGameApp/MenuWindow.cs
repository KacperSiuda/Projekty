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
        public string PlayerName()
        {
            
            return player.PlayerName;
        }
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
            Form1 gameWindow = new Form1();
            gameWindow.Show();
            
        }
    }
}
