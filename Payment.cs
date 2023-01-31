namespace SplidSolution
{
    public class Payment : AbstractExpense
    {
        public User ToUser { get; }

        public Payment(string title, double amount, User from, User to)
        {
            Title = title;
            Amount = amount;
            FromUser = from;
            ToUser = to;
            UserPayment(amount, from, to);
        }

        public void UserPayment(double amount, User fromID, User toID)
        {
            fromID.Balance -= amount;
            toID.Balance += amount;

        }
    }
}