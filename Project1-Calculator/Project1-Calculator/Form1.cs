using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project1_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string digit;  //next digit
        private string num; //keep track of number
        private double firstnum, secondnum, total; //used for operations
        private Boolean decflag = false; //true if dec_click
        private Boolean signflag = false; //false for positive, true for negative
        private Boolean opflag = false; //true when more than one op occurance
        private int optype = 0; //keeps track of last op

        private void button1_Click(object sender, EventArgs e)
        {
            digit = "1";
            num += digit;
            textBox1.Text = num;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            digit = "2";
            num += digit;
            textBox1.Text = num;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            digit = "3";
            num += digit;
            textBox1.Text = num;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            digit = "4";
            num += digit;
            textBox1.Text = num;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            digit = "5";
            num += digit;
            textBox1.Text = num;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            digit = "6";
            num += digit;
            textBox1.Text = num;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            digit = "7";
            num += digit;
            textBox1.Text = num;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            digit = "8";
            num += digit;
            textBox1.Text = num;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            digit = "9";
            num += digit;
            textBox1.Text = num;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            digit = "0";
            num += digit;
            textBox1.Text = num;
        }

        private void buttondec_Click(object sender, EventArgs e)
        {
            if (decflag == false)
            {
                digit = ".";
                num += digit;
                textBox1.Text = num;
                decflag = true;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            //reset variables
            num = "";
            decflag = false;
            signflag = false;
            opflag = false;
            optype = 0;
            firstnum = 0;
            secondnum = 0;
            total = 0;
            textBox1.Text = "0";
        }

        private void posneg_Click(object sender, EventArgs e)
        {
            if (signflag == false)
            {
                digit = "-";
                num = digit + num; //adds in front
                textBox1.Text = num;
                signflag = true;
            }
            else
            {
                char[] trim = { '-' };
                num = num.TrimStart(trim); //remove - from front
                textBox1.Text = num;
                signflag = false;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (opflag == false) //if first op
            {
                firstnum = Convert.ToDouble(num);
                total = total + firstnum;
                textBox1.Text = "";
                num = "";
            }
            else
            {
                secondnum = Convert.ToDouble(num);
                if (optype == 1)
                {
                    total += secondnum;
                }
                if (optype == 2)
                {
                    total -= secondnum;
                }
                if (optype == 3)
                {
                    total *= secondnum;
                }
                if (optype == 4)
                {
                    total /= secondnum;
                }
                textBox1.Text = "";
                num = "";
            }
            opflag = true;
            optype = 1;
            decflag = false;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            secondnum = Convert.ToDouble(num);
            if (optype == 1)
            {
                total += secondnum;
            }
            if (optype == 2)
            {
                total -= secondnum;
            }
            if (optype == 3)
            {
                total *= secondnum;
            }
            if (optype == 4)
            {
                total /= secondnum;
            }
            textBox1.Text = total.ToString();
            opflag = false;
            num = "0";
            //need something for op after equals
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            if (opflag == false) //if first op
            {
                firstnum = Convert.ToDouble(num);
                total = total + firstnum;
                textBox1.Text = "";
                num = "";
            }
            else
            {
                secondnum = Convert.ToDouble(num);
                if (optype == 1)
                {
                    total += secondnum;
                }
                if (optype == 2)
                {
                    total -= secondnum;
                }
                if (optype == 3)
                {
                    total *= secondnum;
                }
                if (optype == 4)
                {
                    total /= secondnum;
                }
                textBox1.Text = "";
                num = "";
            }
            opflag = true;
            optype = 2;
            decflag = false;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (opflag == false) //if first op
            {
                firstnum = Convert.ToDouble(num);
                total = total + firstnum;
                textBox1.Text = "";
                num = "";
            }
            else
            {
                secondnum = Convert.ToDouble(num);
                if (optype == 1)
                {
                    total += secondnum;
                }
                if (optype == 2)
                {
                    total -= secondnum;
                }
                if (optype == 3)
                {
                    total *= secondnum;
                }
                if (optype == 4)
                {
                    total /= secondnum;
                }
                textBox1.Text = "";
                num = "";
            }
            opflag = true;
            optype = 3;
            decflag = false;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (opflag == false) //if first op
            {
                firstnum = Convert.ToDouble(num);
                total = total + firstnum;
                textBox1.Text = "";
                num = "";
            }
            else
            {
                secondnum = Convert.ToDouble(num);
                if (optype == 1)
                {
                    total += secondnum;
                }
                if (optype == 2)
                {
                    total -= secondnum;
                }
                if (optype == 3)
                {
                    total *= secondnum;
                }
                if (optype == 4)
                {
                    total /= secondnum;
                }
                textBox1.Text = "";
                num = "";
            }
            opflag = true;
            optype = 4;
            decflag = false;
        }
    }
}
