using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioural.Strategy
{
    public class LoanApplication : ILoanApplication
    {
        public string ApplicantName { get; set; }
        public int CreditScore { get; set; }
        public bool IsCityDweller { get; set; }
        public int MonthlyIncome { get; set; }
        public int NExistingLoans { get; set; }

        public bool IsLoanApproved(ILoanApprovalStrategy strategy)
        {
            return strategy.IsApproved(this);
        }
    }
}
