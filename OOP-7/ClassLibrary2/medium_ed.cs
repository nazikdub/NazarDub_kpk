using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary2
{
    public class medium_ed
    {
        private string subject;
        private int bal;
        public medium_ed(string subject = "", int bal = 0)
        {
            this.subject = subject;
            this.bal = bal;
        }
        public void Init_Medium_ed()
        {
            System.Console.WriteLine("Введiть предмет");
            this.subject = System.Console.ReadLine();
            System.Console.WriteLine("Введiть бал");
            this.bal = Convert.ToInt32(System.Console.ReadLine());
        }
        public medium_ed(medium_ed _medium_ed)
        {
            this.subject = _medium_ed.subject;
            this.bal = _medium_ed.bal;
        }
        public medium_ed(int bal)
        {
            this.subject = "";
            this.bal = bal;
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
        public void Show_Ed()
        {
            System.Console.WriteLine("Назва предмета - " + subject + " | бал за семестр - " + bal);
        }
    }
}