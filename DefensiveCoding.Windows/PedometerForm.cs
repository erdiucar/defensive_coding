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
            var result = CalculatePercentOfGoalSteps(this.GoalTextBox.Text, this.StepsTextBox.Text);

            PercentResultLabel.Text = "You reached " + decimal.Round(result, 2, MidpointRounding.AwayFromZero) + "% of your goal.";
        }

        private static decimal CalculatePercentOfGoalSteps(string goalSteps, string actualSteps)
        {
            decimal goalStepCount = 0;
            decimal actualStepCount = 0;

            if (string.IsNullOrWhiteSpace(goalSteps)) throw new ArgumentException(message: "Goal must be entered", paramName: nameof(goalSteps));
            if (string.IsNullOrWhiteSpace(actualSteps)) throw new ArgumentException(message: "Actual steps count must be entered", paramName: nameof(actualSteps));

            if (!decimal.TryParse(goalSteps, out goalStepCount)) throw new ArgumentException(message: "Goal must be numeric", paramName: nameof(goalSteps));
            if (!decimal.TryParse(actualSteps, out actualStepCount)) throw new ArgumentException(message: "Actual steps must be numeric", paramName: nameof(actualSteps));

            return CalculatePercentOfGoalSteps(goalStepCount, actualStepCount);
        }

        private static decimal CalculatePercentOfGoalSteps(decimal goalStepCount, decimal actualStepCount)
        {
            if (goalStepCount <= 0) throw new ArgumentException("Goal must be greater than 0", "goalSteps");
            return (actualStepCount / goalStepCount) * 100;
        }
    }
}
