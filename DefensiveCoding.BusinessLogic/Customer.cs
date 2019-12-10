using System;

namespace DefensiveCoding.BusinessLogic
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public decimal CalculatePercentOfGoalSteps(string goalSteps, string actualSteps)
        {
            decimal goalStepCount = 0;
            decimal actualStepCount = 0;

            if (string.IsNullOrWhiteSpace(goalSteps)) throw new ArgumentException(message: "Goal must be entered", paramName: nameof(goalSteps));
            if (string.IsNullOrWhiteSpace(actualSteps)) throw new ArgumentException(message: "Actual steps count must be entered", paramName: nameof(actualSteps));

            if (!decimal.TryParse(goalSteps, out goalStepCount)) throw new ArgumentException(message: "Goal must be numeric", paramName: nameof(goalSteps));
            if (!decimal.TryParse(actualSteps, out actualStepCount)) throw new ArgumentException(message: "Actual steps must be numeric", paramName: nameof(actualSteps));

            return CalculatePercentOfGoalSteps(goalStepCount, actualStepCount);
        }

        public decimal CalculatePercentOfGoalSteps(decimal goalStepCount, decimal actualStepCount)
        {
            if (goalStepCount <= 0) throw new ArgumentException("Goal must be greater than 0", "goalSteps");
            return (actualStepCount / goalStepCount) * 100;
        }

        public void ValidateEmail()
        {
            throw new NotImplementedException();
        }
    }
}
