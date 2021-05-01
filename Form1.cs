using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grapecity_assessment
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // this is used for take only numeric value into bill text box from user.
            if (e.Handled = !char.IsDigit(e.KeyChar))
            {
                errorProvider1.SetError(label2, "Allow Only Numeric Values !");
                label2.Text = "Allow Only Numeric Values !";
            }
            else
            {
                errorProvider1.SetError(label2, "");
                label2.Text = "";
            }
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1bill_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try// This try and catch block is used the handle the flow of program and if error occurs then it would catch by catch block.
            {
                double billamount;
                int tip, numberofperson;
                //These variable is used to store the input values from user. 

                billamount = double.Parse(textBox1bill.Text);
                //This statement is used to take input from textbox and parse into double.


                tip = Convert.ToInt32(numericUpDowntip.Value);
                //this statement is used to take tip% numeric value from numericupdown box in integer form.
                
                numberofperson = Convert.ToInt32(numericUpDown1.Value);
                //this statement is used to take No. of person from numericupdown box in interger form.

                tip = Convert.ToInt32((tip * billamount) / 100);
                double tipp = tip;
                // now convert tip integer valur into double and store into tipp.

                labeltipamount.Text = tipp.ToString("C");
                //this statement is used to show the tip amount into this label as output.

                double total = billamount + tipp;
                labeltotal.Text = total.ToString("C");
                //this statement is used to show the total bill amount into this label as output.

                double tipperperson = tipp / numberofperson;
                if(tipp == 0 || numberofperson == 0)
                {
                    tipperperson = 0.00;
                }
                labeltipperperson.Text = tipperperson.ToString("C");
                //this statement is used to show the tip per person into this label as output.
                
                double totalperperson = total / numberofperson;
                if(total == 0|| numberofperson == 0)
                {
                    totalperperson = 0.00;
                }
                labeltotalperperson.Text = totalperperson.ToString("C");
            }   //this statement is used to show the total bill amount per person into this label as output.

            catch (Exception y)
            {
                //this is used to catch the error and show the exception message into screen. 
                Console.WriteLine(y.Message);
            }

            
        }

        private void numericUpDowntip_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDowntip_Validated(object sender, EventArgs e)
        {
            if (numericUpDowntip.Text == "")
            {
                numericUpDowntip.Text = "0";
            }
        }

        private void numericUpDown1_Validated(object sender, EventArgs e)
        {
            if(numericUpDown1.Text == "")
            {
                numericUpDown1.Text = "0";
            }
        }

        private void labeltipperperson_Validated(object sender, EventArgs e)
        {
            
        }

        private void labeltotalperperson_Validated(object sender, EventArgs e)
        {
           
        }
    }
}
