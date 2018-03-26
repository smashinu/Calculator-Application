using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathamaticsDLL;

namespace Calculator_GUI
{
    public partial class Form1 : Form
    {
        int GeneralCounter = 0;
        double Number1;
        double Number2;
        double Input;
        int Mathametic;
        MathamaticsDLL.Class1 MathsClasses = new MathamaticsDLL.Class1();

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonEqauls_Click(object sender, EventArgs e)
        {
            

            try
            {
                if (Mathametic == 1)
                {
                    string[] Input = textBox1.Text.Split('+');
                    Number2 = Convert.ToInt32(Input[1]);
                }
                else if (Mathametic == 2)
                {
                    string[] Input = textBox1.Text.Split('-');
                    Number2 = Convert.ToInt32(Input[1]);
                }
                else if (Mathametic == 3)
                {
                    string[] Input = textBox1.Text.Split('*');
                    Number2 = Convert.ToInt32(Input[1]);
                }
                else if (Mathametic == 4)
                {
                    string[] Input = textBox1.Text.Split('/');
                    Number2 = Convert.ToInt32(Input[1]);
                }
                textBox1.Text = MathsClasses.Caluculation(Number1, Number2, Mathametic).ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
            }
            
            Number1 = 0;
            Number2 = 0;
        }

        #region Arithmatic Calculations

        

        // Times Equation
        private void ButtonTimes_Click(object sender, EventArgs e)
        {
            //checks to see if i need to add to variable 1 or variable 2
            try
            {
                if (Number1 == 0)
                {
                    Number1 = Convert.ToInt32(textBox1.Text);
                }
                else
                {
                    MessageBox.Show("Problem with Program, please Restart");
                }

                Mathametic = 3;
                textBox1.Text = textBox1.Text + "*";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
            }
            
        }

        //Divide Equation
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            //checks to see if i need to add to variable 1 or variable 2
            try
            {
                if (Number1 == 0)
                {
                    Number1 = Convert.ToInt32(textBox1.Text);
                }
                else
                {
                    MessageBox.Show("Problem with Program, please Restart");
                }

                Mathametic = 4;
                textBox1.Text = textBox1.Text + "/";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
            }
        }
        //Minus Equation
        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            try
            {
                if (Number1 == 0)
                {
                    Number1 = Convert.ToInt32(textBox1.Text);
                }
                else
                {
                    MessageBox.Show("Problem with Program, please Restart");
                }

                Mathametic = 2;
                textBox1.Text = textBox1.Text + "-";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
            }
        }
        //Plus Equation
        private void ButtonPLus_Click(object sender, EventArgs e)
        {
            //checks to see if i need to add to variable 1 or variable 2
            try
            {
                if (Number1 == 0)
                {
                    Number1 = Convert.ToInt32(textBox1.Text);
                }
                else
                {
                    MessageBox.Show("Problem with Program, please Restart");
                }

                Mathametic = 1;
                textBox1.Text = textBox1.Text + "+";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
            }
        }
        #endregion
        #region MyButtons
        private void ButtonNumber1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void ButtonNumber2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void buttonNumber4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void ButtonNumber5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void ButtonNumber6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void ButtonNumber7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void ButtonNumber8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void ButtonNumber9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void ButtonNumber0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }
        #endregion
        #region Root Calculations
        //Sqaure Root Calcuation
        private void buttonSqaureRoot_Click(object sender, EventArgs e)
        { 


          try
          {
                double output;
                output = MathsClasses.SqaureRoot(Convert.ToInt32(textBox1.Text));
                textBox1.Text = output.ToString();
          }  
          catch(Exception ex)
          {
                MessageBox.Show(ex.ToString());
          }
        }
        //CBRT Calculation
        private void ButtonCBRT_Click(object sender, EventArgs e)
        {

            try
            {
                Number1 = Convert.ToInt32(textBox1.Text);
                double Input;
                Input = MathsClasses.CubeRoot(Number1);
                textBox1.Text = Input.ToString();
                Number1 = 0;

            }
            catch (Exception Exception)
            {

                MessageBox.Show(Exception.ToString());
            }
        }
        private void ButtonInv_Click(object sender, EventArgs e)
        {
            // looks good
            try
            {
                double Input = Convert.ToInt32(textBox1.Text);
                Input = MathsClasses.Inverse(Input);
                textBox1.Text = Input.ToString();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
            }
           





            // Not sure if this is right
            //if (GeneralCounter == 0)
            //{
            //    if (Number1 == 0)
            //    {
            //        Number1 = Convert.ToInt32(textBox1.Text);
            //    }
            //    textBox1.Text += "*";
            //    MessageBox.Show("Please Enter in the second number AND click on the INV button again to commence INV calculation");
            //    GeneralCounter++;
            //}
            //else
            //{
            //    try
            //    {
            //        string[] Test = textBox1.Text.Split('*');
            //        Number2 = Convert.ToInt32(Test[1]);
            //        double output;
            //        output = MathsClasses.Inverse(Number1, Number2);
            //        textBox1.Text = output.ToString();
            //        Number1 = 0;
            //        Number2 = 0;
            //    }
            //    catch (Exception exception)
            //    {

            //        MessageBox.Show(exception.Message.ToString(););
            //    }

            //    GeneralCounter = 0;
            //}

        }
        #endregion
        #region Sin,Tan And cos




        //Calculate Tan and display to Textbox
        private void ButtonTan_Click(object sender, EventArgs e)
        {
            try
            {
                double Input;
                Input = Convert.ToInt32(textBox1.Text);
                if (Input >= 90)
                {
                    MessageBox.Show("you can not have a 90 degree corner.");
                    textBox1.Text = "";
                }
                else
                {
                    Input = MathsClasses.Tan(Input);
                    textBox1.Text = Input.ToString();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
            }

            Input = 0;
        }
        //Calculate Sin and Display to TextBox
        private void ButtonSin_Click(object sender, EventArgs e)
        {
            try
            {
                double Input;
                Input = (Convert.ToInt32(textBox1.Text));
                if (Input >= 90)
                {
                    MessageBox.Show("you can not have a 90 degree corner.");
                    textBox1.Text = "";
                }
                else
                {
                    Input = MathsClasses.Sin(Input);
                    textBox1.Text = Input.ToString();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
            }

            Input = 0;
        }

        private void ButtonCos_Click(object sender, EventArgs e)
        {
            try
            {
                double Input;
                Input = (Convert.ToInt32(textBox1.Text));
                if (Input >= 90)
                {
                    MessageBox.Show("you can not have a 90 degree corner.");
                    textBox1.Text = "";
                }
                else
                {
                    Input = MathsClasses.Cosine(Input);
                    textBox1.Text = Input.ToString();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
            }
            Input = 0;
        }
        #endregion

       
    }
}
