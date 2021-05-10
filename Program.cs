using System;

namespace Behavioural.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoanApplication application = new LoanApplication
            {
                ApplicantName = "Sunil",
                CreditScore = 725,
                IsCityDweller = false,
                MonthlyIncome = 50000,
                NExistingLoans = 2
            };

            ILoanApprovalStrategy carStrategy = new CarLoanApprovalStrategy();
            ILoanApprovalStrategy homeStrategy = new HomeLoanApprovalStrategy();

            Console.WriteLine(application.IsLoanApproved(carStrategy));
            Console.WriteLine(application.IsLoanApproved(homeStrategy));
        }
    }
}
