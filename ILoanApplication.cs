namespace Behavioural.Strategy
{
    public interface ILoanApplication
    {
        public string ApplicantName { get; set; }
        public int CreditScore { get; set; }
        public bool IsCityDweller { get; set; }
        public int MonthlyIncome { get; set; }
        public int NExistingLoans { get; set; }

        bool IsLoanApproved(ILoanApprovalStrategy strategy);
    }
}