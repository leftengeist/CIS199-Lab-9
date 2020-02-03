//N5284
//Lab 9
//April 21, 2019
//CIS 199-75
//Displays a date using a class that can be changed by a user

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9
{
    public partial class Lab9 : Form
    {
        Date output = new Date(1, 1, 2000); //Create date object and give it startup value

        // Precondition:  None
        // Postcondition: Create form and output
        public Lab9()
        {
            InitializeComponent();
            outDateLbl.Text = $"{output}";
        }

        // Precondition:  "Update Month" button is pressed
        // Postcondition: Check input, update month, and output
        private void updateMonthBtn_Click(object sender, EventArgs e)
        {
            int month;  // The month value

            if (Int32.TryParse(inMonthTxt.Text, out month))
            {
                output.Month = month;
                outDateLbl.Text = $"{output}";
            }
            else
                MessageBox.Show($"Please enter a valid month");
        }

        // Precondition:  "Update Day" button is pressed
        // Postcondition: Check input, update day, and output
        private void updateDayBtn_Click(object sender, EventArgs e)
        {
            int day;    // The day value

            if (Int32.TryParse(inDayTxt.Text, out day))
            {
                output.Day = day;
                outDateLbl.Text = $"{output}";
            }
            else
                MessageBox.Show($"Please enter a valid day");
        }

        // Precondition:  "Update Year" button is pressed
        // Postcondition: Check input, update year, and output
        private void updateYearBtn_Click(object sender, EventArgs e)
        {
            int year;   // The year value
            if (Int32.TryParse(inYearTxt.Text, out year))
            {
                output.Year = year;
                outDateLbl.Text = $"{output}";
            }
            else
                MessageBox.Show($"Please enter a valid year");
        }
    }
}
