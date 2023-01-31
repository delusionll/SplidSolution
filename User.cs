using System.ComponentModel.DataAnnotations;

namespace SplidSolution
{
    public class User
    {
        [Key]
        public int UserID { get; set; } // ID Юзера
        public string Name { get; set; } //Свойство класса Имя пользователя
        public double Balance { get; set; } //Свойство класса баланс пользователя

        public User(string name) //Конструктор объекта Юзер
        {
            Name = name;
            Balance = 0;
        }
        public User() { }
    }
}