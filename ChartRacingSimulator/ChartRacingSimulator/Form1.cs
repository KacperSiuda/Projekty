﻿using System;
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
        public Greyhound[] greyhound = new Greyhound[4];
        private Guy[] guy = new Guy[3];
        Random Randomizer = new Random();

        public Form1()
        {
            InitializeComponent();
            CreateObjects();

        }
        
        private void CreateGuysObjects()
        {
            guy[0] = new Guy()
            {
                Name = "Joe",
                Cash = 70,
                MyLabel = label6,
                MyRadioButton = radioButton1,

            };
            guy[1] = new Guy()
            {
                Name = "Bob",
                Cash = 70,
                MyLabel = label7,
                MyRadioButton = radioButton2,

        private void CreateObjects()
        {


            greyhound[0] = new Greyhound()
            {
                MyPictureBox = pictureBox2,
                StartingPosition = pictureBox2.Left,
                RacetrackLenght = raceTrackPictureBox.Width - pictureBox2.Width,
                MyRandom = Randomizer
                

            };
            greyhound[1] = new Greyhound()
            {
                MyPictureBox = pictureBox3,
                StartingPosition = pictureBox3.Left,
                RacetrackLenght = raceTrackPictureBox.Width - pictureBox3.Width,
                MyRandom = Randomizer


            };
            greyhound[2] = new Greyhound()
            {
                MyPictureBox = pictureBox4,
                StartingPosition = pictureBox4.Left,
                RacetrackLenght = raceTrackPictureBox.Width - pictureBox4.Width,
                MyRandom = Randomizer


            };
            greyhound[3] = new Greyhound()
            {
                MyPictureBox = pictureBox5,
                StartingPosition = pictureBox5.Left,
                RacetrackLenght = raceTrackPictureBox.Width - pictureBox5.Width,
                MyRandom = Randomizer


            };
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i <= 3; i++)
            {
                greyhound[i].Run();
            }

        private void button2_Click(object sender, EventArgs e)
        {
            int cash = Convert.ToInt16(numericUpDown1.Text);
            int greyhoundNumber = Convert.ToInt16(numericUpDown2.Text);

            guy[0].PlaceBet(cash, greyhoundNumber);
        }
    }
}
