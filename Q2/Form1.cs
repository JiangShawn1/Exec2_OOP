using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gameButton_Click(object sender, EventArgs e)
        {            
            int d1 = 0;  int d2 = 0;  int d3 = 0;  int d4 = 0;
            do
            {
                Random random = new Random();
                d1 = random.Next(1, 7);
                d2 = random.Next(1, 7);
                d3 = random.Next(1, 7);
                d4 = random.Next(1, 7);
            }
            while (d1 != d2 && d1 != d3 && d1 != d4 && d2 != d3 && d2 != d4 && d3 != d4);
            {
                int max = 0; int value = 0;

                if (d1 == d2) { value = d3 + d4; }
                if (value > max) { max = value; }

                if (d1 == d3) { value = d2 + d4; }
                if (value > max) { max = value; }

                if (d1 == d4) { value = d2 + d3; }
                if (value > max) { max = value; }

                if (d2 == d3) { value = d1 + d4; }
                if (value > max) { max = value; }

                if (d2 == d4) { value = d1 + d3; }
                if (value > max) { max = value; }

                if (d3 == d4) { value = d1 + d2; }
                if (value > max) { max = value; }

                diceLabel.Text = $"{d1}{d2}{d3}{d4}";
                valueLabel.Text = max.ToString();
            }

        }
        
    }

}
