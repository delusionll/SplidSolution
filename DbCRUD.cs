using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace SplidSolution
{
    public class DbCRUD
    {
        private readonly SplidContext _db;
        public DbCRUD(SplidContext db)
        {
            _db = db;
        }

        public static User GetUserById(int id)
        {
            using (var _db = new SplidContext())
            {
                var user = _db.Users.FirstOrDefault<User>(x => x.UserID == id);
                return user;
            }
        }

        public static ICollection<User> GetAllUsers()
        {
            using (var _db = new SplidContext())
            {
                return _db.Users
                .AsNoTracking().ToList();
            }
        }

    }
}