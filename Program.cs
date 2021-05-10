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

            Console.WriteLine(application.IsLoanApproved(a => a.CreditScore >= 700));
            Console.WriteLine(application.IsLoanApproved(a => a.CreditScore >= 750 && a.MonthlyIncome >= 50000));
        }
    }
}
