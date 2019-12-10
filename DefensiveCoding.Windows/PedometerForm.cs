using DefensiveCoding.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DefensiveCoding.Windows
{
    public partial class PedometerForm : Form
    {
        public PedometerForm()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            var customer = new Customer();
            var result = customer.CalculatePercentOfGoalSteps(this.GoalTextBox.Text, this.StepsTextBox.Text);

            PercentResultLabel.Text = "You reached " + decimal.Round(result, 2, MidpointRounding.AwayFromZero) + "% of your goal.";
        }
    }
}
