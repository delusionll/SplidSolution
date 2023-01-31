using System;
using System.Windows.Controls;
using System.Data.Entity;
using System.Linq;

namespace SplidSolution
{
    internal class ConsoleProgram
    {
        private static void Main(string[] args)
        {
            using (var db = new DB())
            {
                User l = new User("Lexa");
                db.Users.Add(l);
                User v = new User("Vlad");
                db.Users.Add(v);
                User p = new User("Polina");
                db.Users.Add(p);
                db.SaveChanges();
                Console.Write("Hello");

                Payment pay1 = new Payment("TestPayment", 100, l, p);

                var query = from x in db.Users
                            orderby x.Name
                            select x;
                foreach(var item in query)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }
}