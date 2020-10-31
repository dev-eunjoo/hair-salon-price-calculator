//Name and student number: Eunjoo Na, 000811369
//File date : 2020.10.11
//Program's purpose: Make a window application to calculate Hair service fee   
//I, Eunjoo Na, 000811369 certify that this material is my original work.  
//No other person's work has been used without due acknowledgement.

using System;
using System.Windows.Forms;

namespace Lab2B
{
    /// <summary>
    /// This class is the Form1 class in the program 
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Form1 constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            initialize();
        }

        /// <summary>
        /// calculateBtn_Click method for executing when click the calculateBtn
        /// </summary>
        /// <param name="sender">object to send</param>
        /// <param name="e">click event</param>
        private void calculateBtn_Click(object sender, EventArgs e)
        {
            //create serviceFee and set as 0 
            decimal serviceFee = 0;
            //create discountPercent and set as 0 
            decimal discountPercent = 0;

            //determine service base fee
            if (janeRB.Checked)
                serviceFee = 30;
            else if (patRB.Checked)
                serviceFee = 45;
            else if (ronRB.Checked)
                serviceFee = 40;
            else if (sueRB.Checked)
                serviceFee = 50;
            else if (lauraRB.Checked)
                serviceFee = 55;

            // validate at least one service is checked. 
            if (cutCB.Checked == false && colourCB.Checked == false && highlightsCB.Checked == false && extensionsCB.Checked == false)
            {
                MessageBox.Show("You must select at least one service", "Missing Service(s)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //determine service optional services fee
            if (cutCB.Checked)
                serviceFee += 30;
            if (colourCB.Checked)
                serviceFee += 40;
            if (highlightsCB.Checked)
                serviceFee += 50;
            if (extensionsCB.Checked)
                serviceFee += 200;


            //determine discount percent based on client type
            if (childRB.Checked)
                discountPercent = 10;
            else if (studentRB.Checked)
                discountPercent = 5;
            else if (seniorRB.Checked)
                discountPercent = 15;

            //visitNumber for the number of client visits
            int visitNumber;

            // validate number of visits is an integer greater than 0
            if (!int.TryParse(numberOfVisitTB.Text, out visitNumber) || (visitNumber <= 0))
            {

                MessageBox.Show("Number of Visits must be an integer greater than 0", "Incorrect Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //determine discount percent based on the number of client visits
            if (visitNumber >= 1 && visitNumber <= 3)
                discountPercent += 0;
            else if (visitNumber >= 4 && visitNumber <= 8)
                discountPercent += 5;
            else if (visitNumber >= 9 && visitNumber <= 13)
                discountPercent += 10;
            else
                discountPercent += 15;

            //output the result 
            decimal total = serviceFee * (100- discountPercent)/100;
            totalLbl.Text = total.ToString("C");
        }

        /// <summary>
        /// clearBtn_Click method for executing when click the clearBtn
        /// </summary>
        /// <param name="sender">object to send</param>
        /// <param name="e">click event</param>
        private void clearBtn_Click(object sender, EventArgs e)
        {
            //execute initialize method
            initialize();
        }

        /// <summary>
        /// exitBtn_Click method for executing when click the exitBtn
        /// </summary>
        /// <param name="sender">object to send</param>
        /// <param name="e">click event</param>
        private void exitBtn_Click(object sender, EventArgs e)
        {
            //exit the application
            Application.Exit();
        }

        /// <summary>
        /// initialize method to reset the display
        /// </summary>
        private void initialize ()
        {
            //reset and/or clear controls
            janeRB.Checked = true;

            cutCB.Checked = false;
            colourCB.Checked = false;
            highlightsCB.Checked = false;
            extensionsCB.Checked = false;

            adultRB.Checked = true;

            numberOfVisitTB.Clear();
            totalLbl.ResetText();
        }
    }
}
