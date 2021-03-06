﻿using System;
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
        public RadioButton MyRadioButton = null;
        public Label MyLabel = null;

        public void UpdateLabels()
        {
            MyLabel.Text = (Name + "obstawił");
            MyRadioButton.Text = (Name + "ma" + Cash);

        }

        public void ClearBet()
        {
            MyBet = null;
        }

        public bool PlaceBet(int Amount, int DogToWin)
        {
            if (Amount <= Cash)
            {

                Cash = Cash - Amount;
                Amount = MyBet.Amount;
                DogToWin = MyBet.Dog;
                MyBet.Bettor = this;
                return true;

            }
            else
            {
                return false;
            }

        }
        public void Collect(int Winner)
        {

        }
    }
}
