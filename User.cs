using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SplidSolution
{
    public class User
    {
        [Key]
        public int UserID { get; set; } // ID Юзера
        public string? Name { get; set; } //Свойство класса Имя пользователя
        public double Balance { get; set; } //Свойство класса баланс пользователя

        public User(string name) //Конструктор объекта Юзер
        {
            Name = name;
            Balance = 0;
        }

        public User()
        { } //Конструктор без параметров для БД EF

        public static User CreateUser(string newUserName)
        {
            User user = new User(newUserName);

            using (var _db = new SplidContext())
            {
                _db.Users.Add(user);
                _db.SaveChanges();
            }
            return user;

        }
    }
}