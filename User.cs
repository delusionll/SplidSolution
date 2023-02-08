using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SplidSolution
{
    public class User
    {
        [Key]
        public int UserID { get; set; } // ID �����
        public string? Name { get; set; } //�������� ������ ��� ������������
        public double Balance { get; set; } //�������� ������ ������ ������������

        public User(string name) //����������� ������� ����
        {
            Name = name;
            Balance = 0;
        }

        public User()
        { } //����������� ��� ���������� ��� �� EF

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