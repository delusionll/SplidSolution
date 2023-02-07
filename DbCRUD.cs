using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace SplidSolution
{
    public class DbCRUD
    {
        private readonly DB _db;
        public DbCRUD(DB db)
        {
            _db = db;
        }

        public static ICollection<User> GetAllUsers()
        {
            using (var _db = new DB())
            {
                return _db.Users
                .AsNoTracking().ToList();
            }
        }

        public static void CreateUser(User newUser)
        {
            using (var _db = new DB())
            {
                if(DbCRUD.GetAllUsers().Contains(newUser)) { Console.WriteLine("User is already exist"); }
                else
                {
                _db.Users.Add(newUser);
                _db.SaveChanges();
                }
            }
        }
    }
}