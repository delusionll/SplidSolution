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