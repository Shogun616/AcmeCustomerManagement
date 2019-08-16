using Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        /// <summary>
        /// Calculates the percent of the step goal reached.
        /// </summary>
        /// <param name="goalSteps"></param>
        /// <param name="actualSteps"></param>
        /// <returns></returns>
        public decimal CalculatePercentOfGoalSteps(string goalSteps, string actualSteps)
        {
            if (string.IsNullOrWhiteSpace(goalSteps)) throw new ArgumentException("Goal must be entered", "goalSteps");
            if (string.IsNullOrWhiteSpace(actualSteps)) throw new ArgumentException("Actual steps count must be entered", "actualSteps");

            // Try 3
            if (!decimal.TryParse(goalSteps, out decimal goalStepCount)) throw new ArgumentException("Goal must be numeric");
            if (!decimal.TryParse(actualSteps, out decimal actualStepCount)) throw new ArgumentException("Actual steps must be numeric", "actualSteps");

            return CalculatePercentOfGoalSteps(goalStepCount, actualStepCount);
        }

        public decimal CalculatePercentOfGoalSteps(decimal goalStepCount, decimal actualStepCount)
        {
            if (goalStepCount <= 0) throw new ArgumentException("Goal must be greater than 0", "goalSteps");
            return (actualStepCount / goalStepCount) * 100;
        }
        public OperationResult ValidateEmail()
        {
            var op = new OperationResult();

            if (string.IsNullOrWhiteSpace(this.EmailAddress))
            {
                op.Success = false;
                op.AddMessage("Email Address is null");
            }

            if (op.Success)
            {
                var isValidFormat = true;

                if (!isValidFormat)
                {
                    op.Success = false;
                    op.AddMessage("Email Address is not in a correct format");
                }
            }

            if (op.Success)
            {
                var isRealDomain = true;

                if (!isRealDomain)
                {
                    op.Success = false;
                    op.AddMessage("Email Address does not include a valid domain");
                }
            }

            return op;
        }
    }
}
