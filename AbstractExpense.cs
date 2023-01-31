using System.ComponentModel.DataAnnotations;

namespace SplidSolution
{
    public abstract class AbstractExpense
    {
        [Key]
        public int ExpenseID { get; set; }
        public string Title { get; set; }
        public double Amount { get; set; }
        public User FromUser { get; set; }
    }
}