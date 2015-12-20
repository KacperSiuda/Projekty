using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private MenuMaker Menu;
        public Form1()
        {
            InitializeComponent();
            Menu = new MenuMaker() { Radomizer = new Random() };

        }

        private void UpdateForm()
        {
            label1.Text = "Szef kuchni na dzisiaj poleca";
            label2.Text = Menu.GetMenuItem();
            label3.Text = Menu.GetMenuItem();
            label4.Text = Menu.GetMenuItem();
            label5.Text = Menu.GetMenuItem();
            label6.Text = "Smacznego :)";


        }



        private void button1_Click(object sender, EventArgs e)
        {

            UpdateForm();

        }



    }
}
