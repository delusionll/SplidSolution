using System.ComponentModel.DataAnnotations;
using System.Security.RightsManagement;

namespace SplidSolution
{
    public class SimplePayment
    {
        [Key]
        public  int PaymentId { get; set; }
        public User ToUser { get; }
        public string Title { get; }
        public double Amount { get; }
        public User FromUser { get; }

        public SimplePayment(string title, double amount, User from, User to)
        {
            Title = title;
            Amount = amount;
            FromUser = from;
            ToUser = to;
            UserPayment(amount, from, to);
        }

        public static void UserPayment(double amount, User fromID, User toID)
        {
            fromID.Balance -= amount;
            toID.Balance += amount;
        }

        public static SimplePayment CreateSimplePayment(string title, double amount, User fromID, User toID)
        {
            SimplePayment simplePayment = new SimplePayment(title, amount, fromID, toID);
            UserPayment(amount, fromID, toID);
            

            return simplePayment;
        }

        public SimplePayment() { } //Конструктор без параметров для БД EF
    }
}