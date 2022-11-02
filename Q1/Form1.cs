using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nweGameButton_Click(object sender, EventArgs e)
        {
            string value=string.Empty;
            int[] ans =new int[] { 0,1,2,3,4,5,6,7,8,9 };
            Random random = new Random();
            ans = ans.OrderBy(x => random.Next()).ToArray();

            for(int i = 0; i < 4; i++)
            {
               value+=(ans[i]).ToString();               

            }            
            answerLabel.Text = value;
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            int A = 0; int B = 0;

            string input = answerTextBox.Text;
            // int input1 = Convert.ToInt32(input);
            string answer = answerLabel.Text;
            //int answer1 = Convert.ToInt32(answer);

            int[]inp=new int[] { input[0] , input[1] , input[2] , input[3] };
            int[]ans=new int[] { answer[0], answer[1], answer[2], answer[3], };

            for(int i = 0; i < inp.Length; i++)
            {
                for (int k = 0; k < ans.Length; k++)
                {
                    if(ans[i] == inp[k])
                    {
                        B++;
                        if (i == k)
                        {
                            B =B- 1;
                            A =A+ 1;
                        }
                    }

                }
            }   
            HintLabel.Text = $"{A}A{B}B";
        }
    }
}
