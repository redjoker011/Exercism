static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if (IsPositive(balance) && (int)balance < 1000)
        {
            return 0.5F;
        }
        else if ((IsPositive(balance) && (int)balance >= 1000) && (int)balance < 5000)
        {
            return 1.621F;
        }
        else if (IsPositive(balance) && (int)balance >= 5000)
        {
            return 2.475F;
        }
        else
        {
            return 3.213F;
        }
    }

    public static decimal Interest(decimal balance)
    {
        float interestRate = InterestRate(balance);
        return ((decimal)interestRate / 100) * balance;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        decimal interest = Interest(balance);
        return balance + interest;
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        decimal accumulatedBalance = balance;
        do
        {
            accumulatedBalance = AnnualBalanceUpdate(accumulatedBalance);
            years++;
        }while(accumulatedBalance <= targetBalance);

        return years;
    }

    private static bool IsPositive(decimal amount)
    {
        return amount >= 0;
    }
}
