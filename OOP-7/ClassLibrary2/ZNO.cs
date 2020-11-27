using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary2
{
    public class ZNO
    {
        private string subject;
        private int bal;
        public void Init_Zno()
        {
            System.Console.WriteLine("Введiть предмет ЗНО");
            this.subject = System.Console.ReadLine();
            System.Console.WriteLine("Введiть бал");
            this.bal = Convert.ToInt32(System.Console.ReadLine());
        }
        public ZNO(string subject = "", int bal = 0)
        {
            this.subject = subject;
            this.bal = bal;
        }
        public ZNO(int bal)
        {
            //Тільки бал, тому що в конструктор по замов. можна передти тільки перший параметр (subjct)
            // а тільки другий не вийде
            this.subject = "";
            this.bal = bal;
        }
        public ZNO(ZNO zno)
        {
            this.subject = zno.subject;
            this.bal = zno.bal;
        }
        public void Set_subject(string subject)
        {
            this.subject = subject;
        }
        public void Set_bal(int bal)
        {
            this.bal = bal;
        }
        public string Get_subject()
        {
            return subject;
        }
        public int Get_bal() { return bal; }
        public void Show_ZNO()
        {
            System.Console.WriteLine("Назва предмета - " + subject + " | бал ЗНО - " + bal);
        }
    }
}
