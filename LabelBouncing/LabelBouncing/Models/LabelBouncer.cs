using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelBouncing.Models
{
    class LabelBouncer
    {
        public Label MyLabel;
        public bool GoFoward = true;

        public void Move()
        {
            if (MyLabel != null)
            {
                if (GoFoward == true)
                {
                    MyLabel.Left += 5;
                    if (MyLabel.Left > MyLabel.Parent.Width - MyLabel.Width)
                    {
                        GoFoward = false;
                    }
                }
                else
                {
                    MyLabel.Left -= 5;
                    if(MyLabel.Left <= 0)
                    {
                        GoFoward = true;
                    }
                }
            }
        }


    }
}
