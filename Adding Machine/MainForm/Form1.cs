using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class frmMain : Form
    {   //This is the code for the main (and only) form.

        //The array that will hold the values that will be entered is declared here. It can hold up to 50 values, but
        //that won't be a problem.
        double[] feedArray = new double[50];
        int first = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {       //This is the code for the Add button.
            try
            {       //First it makes sure that what the user put into the text box is actually a number.
                if (double.TryParse(txtInput.Text, out double input) == true)
                {       //Then it makes sure that said number is greater than 0 and a variable that checks if this calculation
                        //is the first in the series.
                    if (input > 0 && first == 0)
                    {
                        //If it fits those conditions, it sets the value of the lowest element to what the user put in,
                        //adds what they put in to the list box, and increments the "first" variable, so this bit won't
                        //run again until the Clear or Final Total buttons are clicked.
                        feedArray[Array.IndexOf(feedArray, 0)] = input;
                        lbFeed.Items.Add(input.ToString());
                        first++;
                    }
                        //If it doesn't fit those previous conditions, it checks if the input is greater than 0, that the last
                        //element isn't populated, and that the "first" variable has been modified.
                    else if (input > 0 && feedArray[49] == 0 && first != 0)
                    {       //If these conditions are met, it sets the value of the lowest element to the user input, 
                        //and adds what the user put in in the list box along with a plus sign to signify that this is being
                        //added to what came before it.
                        feedArray[Array.IndexOf(feedArray, 0)] = input;
                        lbFeed.Items.Add("+ " + input.ToString());
                    }
                    //If none of the previous conditions are met, the program checks to see if the last element of the 
                    //array has already been populated.
                    else if (feedArray[49] != 0)
                    {
                        //A variable is created that will hold the total of everything that's been put into the array,
                        //and then the array is cleared. That total is then put into the first element of the array,
                        //and the value that the user was attempting to put in is put into the next element; then the
                        //value that the user just put in is displayed in the list box.
                        double hold = feedArray.Sum();
                        Array.Clear(feedArray, 0, 50);
                        feedArray[0] = hold;
                        feedArray[1] = input;
                        lbFeed.Items.Add("+ " + feedArray[1]);
                    }
                }

                //This is the error that comes up if the input is left blank when this button is clicked.
                else if (txtInput.Text == "")
                {
                    throw new Exception("Please insert a value by typing it into the smaller text box before you click the Add button.");
                }
                //It's assumed the only other case is that the user entered something that's not a number.
                else
                {
                    throw new Exception("Please only use numeric values for your inputs (decimals are allowed).");
                }

                //This sets up the user to the ideal state for the next number.
                txtInput.Text = "";
                txtInput.Focus();

                //This makes it so if the list box is so full that it needs to scroll, it'll automatically stay at
                //the bottom.
                lbFeed.TopIndex = lbFeed.Items.Count - 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btnClear_Click(object sender, EventArgs e)
        {       //This is the code for the Clear button. It clears the array, the list box, text boxes, and resets
            //the variable that keeps track of whether the number being inserted is the first one or not.
            Array.Clear(feedArray, 0, 50);
            lbFeed.Items.Clear();
            txtInput.Text = "";
            txtInput.Focus();
            first = 0;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {       //This is the code for the Subtract button. It's almost completely identical to the Add button code.
            try
            {      
                if (double.TryParse(txtInput.Text, out double input) == true)
                {       
                    if (input > 0 && first == 0)
                    {
                         
                        feedArray[Array.IndexOf(feedArray, 0)] = input;
                        lbFeed.Items.Add(input.ToString());
                        first++;
                    }
                    
                    else if (input > 0 && feedArray[49] == 0 && first != 0)
                    {       //The only difference is that the input variable is now being multiplied by -1, BUT only
                            //when it's not the first number being put in. All buttons just place the number in if 
                            //it's the first number being inserted.
                        input *= -1;
                        feedArray[Array.IndexOf(feedArray, 0)] = input;
                        lbFeed.Items.Add("- " + (input * -1).ToString());
                    }
                    
                    else if (feedArray[49] != 0)
                    {
                            //Same as the Add button, but turns the input negative.
                        input *= -1;
                        double hold = feedArray.Sum();
                        Array.Clear(feedArray, 0, 50);
                        feedArray[0] = hold;
                        feedArray[1] = input;
                        lbFeed.Items.Add("- " + (input *= -1).ToString());
                    }
                }

                
                else if (txtInput.Text == "")
                {
                    //The error that arises if the user doesn't put in any values.
                    throw new Exception("Please insert a value by typing it into the smaller text box before you click the Subtract button.");
                }
                
                else
                {   //The error that arises in the event that none of the previous criteria are met, which pretty much
                    //just leaves if they put in something that wasn't a number.
                    throw new Exception("Please only use numeric values for your inputs (decimals are allowed).");
                }
                txtInput.Text = "";
                txtInput.Focus();
                lbFeed.TopIndex = lbFeed.Items.Count - 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void btnMultiply_Click(object sender, EventArgs e)
        {       //This is the code for the Multiply button.
            try
            {       //Check if input is a number.
                if (double.TryParse(txtInput.Text, out double input) == true)
                {       //Same as the other buttons if it's the first number being entered.
                    if (input > 0 && first == 0)
                    {


                        feedArray[Array.IndexOf(feedArray, 0)] = input;
                        lbFeed.Items.Add(input.ToString());
                        first++;
                    }
                    //If it's not the first number and the input is greater than 0...
                    else if (input > 0 && first != 0)
                    {   //...the total of the array is put into a variable, and that total is multiplied by the input.
                        //That total is put into another variable, the array is cleared, and the second variable is put
                        //into the array.
                        double multiple = feedArray.Sum();
                        double final = multiple * input;
                        Array.Clear(feedArray, 0, 50);
                        feedArray[0] = final;
                        lbFeed.Items.Add("x " + input.ToString());
                    }

                }


                else if (txtInput.Text == "")
                {   //Exception if input is blank.
                    throw new Exception("Please insert a value by typing it into the smaller text box before you click the Multiply button.");
                }

                else
                {   //Exception if input is not just a number.
                    throw new Exception("Please only use numeric values for your inputs (decimals are allowed).");
                }

                txtInput.Text = "";
                txtInput.Focus();
                lbFeed.TopIndex = lbFeed.Items.Count - 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btnDivide_Click(object sender, EventArgs e)
        {       //This is the code for the Divide button. It's very similar to the Multiply button.
            try
            {
                if (double.TryParse(txtInput.Text, out double input) == true)
                {
                    if (input > 0 && first == 0)
                    {

                        feedArray[Array.IndexOf(feedArray, 0)] = input;
                        lbFeed.Items.Add(input.ToString());
                        first++;
                    }

                    else if (input > 0 && first != 0)
                    {   //The only difference is in here. Instead of multiplying the total of the array, like the
                        //Multiply button, it divides the total by the user input instead.
                        double numerator = feedArray.Sum();
                        double final = numerator / input;
                        Array.Clear(feedArray, 0, 50);
                        feedArray[0] = final;
                        lbFeed.Items.Add("/ " + input.ToString());
                    }


                }


                else if (txtInput.Text == "")
                {
                    throw new Exception("Please insert a value by typing it into the smaller text box before you click the Divide button.");
                }

                else
                {
                    throw new Exception("Please only use numeric values for your inputs (decimals are allowed).");
                }

                txtInput.Text = "";
                txtInput.Focus();
                lbFeed.TopIndex = lbFeed.Items.Count - 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {       //This is the code for the Total button.
            try
            {
                if (first != 0)
                {
                    //The array is cleared when this button is hit, and the sum of it all is displayed, and moved 
                    //into the first element of the array. Think of the "=" button on a calculator.
                    double final = feedArray.Sum();
                    Array.Clear(feedArray, 0, 50);
                    feedArray[0] = final;
                    lbFeed.Items.Add("Total: " + final.ToString());
                    first = 1;
                }
                else
                {
                    throw new Exception("You need to insert values before you can retreive a total.");
                }
                txtInput.Focus();
                lbFeed.TopIndex = lbFeed.Items.Count - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {   //This is code for some hotkeys that the user could use. If they hit F1 while the focus is still on
            //the input text box, the Add button is pushed. F2 pushes the Subtract button, F3 Multiply, F4 Divide.
            if (e.KeyData == Keys.F1)
            {
                btnAdd_Click(btnAdd, new EventArgs());
                e.Handled = true;
            }
            else if (e.KeyData == Keys.F2)
            {
                btnSubtract_Click(btnSubtract, new EventArgs());
                e.Handled = true;
            }
            else if (e.KeyData == Keys.F3)
            {
                btnMultiply_Click(btnMultiply, new EventArgs());
                e.Handled = true;
            }
            else if (e.KeyData == Keys.F4)
            {
                btnDivide_Click(btnDivide, new EventArgs());
                e.Handled = true;
            }
            //The form is also set up to allow the user to hit "Alt + (first letter of the word in the button)" for
            //any of the buttons.
        }
    }
}
