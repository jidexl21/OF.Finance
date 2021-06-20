using System;

namespace OF.Finance.LoanProduct
{
    public class LoanProduct
    {
        /// <summary>
        /// The Identifying code of the Loan product
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// This specified the minimum nuumber of elapsed Periods that must be fully paid before a loan offset can be applied
        /// </summary>
        public int MinimumOffsetPeriod { get; set; }
        /// <summary>
        /// This calculates the minimum number of days before a loan offset can be applied as a percentage of the loan duration
        /// </summary>
        public int MinimumOffsetPeriodPercent { get; set; }

        /// <summary>
        /// this is the annual interestRate
        /// </summary>
        public decimal InterestRate { get; set; }
        /// <summary>
        /// This period must elapse before the next loan is applied for
        /// </summary>
        public int MinimumLoanIntervalDays { get; set; }

        /// <summary>
        /// RemainingMonths * MonthlyInterestRate
        /// </summary>
        public decimal OffsetFee { get; set; }
    }
}
