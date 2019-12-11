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
            if (string.IsNullOrWhiteSpace(goalSteps)) throw new ArgumentException(message: "Goal must be entered");
            if (string.IsNullOrWhiteSpace(actualSteps)) throw new ArgumentException(message: "Actual steps count must be entered");

            decimal goalStepCount = 0;
            if (!decimal.TryParse(goalSteps, out goalStepCount)) throw new ArgumentException(message: "Goal must be numeric");
            
            decimal actualStepCount = 0;
            if (!decimal.TryParse(actualSteps, out actualStepCount)) throw new ArgumentException(message: "Actual steps must be numeric");

            return CalculatePercentOfGoalSteps(goalStepCount, actualStepCount);
        }

        public decimal CalculatePercentOfGoalSteps(decimal goalStepCount, decimal actualStepCount)
        {
            if (goalStepCount <= 0) throw new ArgumentException("Goal must be greater than 0", "goalSteps");
            return (actualStepCount / goalStepCount) * 100;
        }

        public void ValidateEmail()
        {
            if (string.IsNullOrWhiteSpace(this.EmailAddress)) throw new ArgumentException("Email address is null");

            var isValidFormat = true;
            if (!isValidFormat) throw new ArgumentException("Email address is not in a correct format");

            var isRealDomain = true;
            if (!isRealDomain) throw new ArgumentException("Email address does not include a valid domain");
        }
    }
}
