using System.ComponentModel.DataAnnotations;

namespace SplidSolution
{
    public class User
    {
        [Key]
        public int UserID { get; set; } // ID �����
        public string Name { get; set; } //�������� ������ ��� ������������
        public double Balance { get; set; } //�������� ������ ������ ������������

        public User(string name) //����������� ������� ����
        {
            Name = name;
            Balance = 0;
        }
        public User() { }
    }
}