using System;
using System.Windows.Forms;

namespace CalanderReasoningWindowApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string y = dateTimePicker2.Value.DayOfWeek.ToString();
            MessageBox.Show(y);
        }

        private void btnTestLeapYear_Click(object sender, EventArgs e)
        {
            int y = dateTimePicker1.Value.Year;

            if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
            {
                MessageBox.Show($"{y} is a Leap year");
            }
            else
            {
                MessageBox.Show($"{y} is not a Leap Year");
            }
        }
    }
}
