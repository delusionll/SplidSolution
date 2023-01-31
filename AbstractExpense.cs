namespace SplidSolution
{
    public abstract class AbstractExpense
    {
        public int ExpenseID { get; set; }
        public string Title { get; set; }
        public double Amount { get; set; }
        public int FromId { get; set; }
    }
}