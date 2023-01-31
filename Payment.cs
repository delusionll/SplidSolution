namespace SplidSolution
{
    public class Payment : AbstractExpense
    {
        public int ToID { get; }

        public Payment(string title, double amount, int from, int to)
        {
            Title = title;
            Amount = amount;
            FromId = from;
            ToID = to;
        }

        public void UserBalanceChange(double fromBalance, double toBalance)
        {
        }
    }
}