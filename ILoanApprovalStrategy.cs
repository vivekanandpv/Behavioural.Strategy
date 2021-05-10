namespace Behavioural.Strategy
{
    public interface ILoanApprovalStrategy
    {
        bool IsApproved(ILoanApplication application);
    }

    public class CarLoanApprovalStrategy : ILoanApprovalStrategy
    {
        public bool IsApproved(ILoanApplication application)
        {
            return application.CreditScore > 700;
        }
    }

    public class HomeLoanApprovalStrategy : ILoanApprovalStrategy
    {
        public bool IsApproved(ILoanApplication application)
        {
            return application.CreditScore >= 750 && application.MonthlyIncome > 50000;
        }
    }
}