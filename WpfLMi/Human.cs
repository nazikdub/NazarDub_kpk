using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfLMI
{
    public class Human : INotifyPropertyChanged
    {
        private string name;
        private string surname;
        private string birthday;
        public Human(string name = "", string surname = "", string birthday = "")
        {
            this.name = name;
            this.surname = surname;
            this.birthday = birthday;
        }
        public Human(Human human)
        {
            this.name = human.name;
            this.surname = human.surname;
            this.birthday = human.birthday;
        }
        public Human(string surname, string birthday)
        {
            this.name = "";
            this.surname = surname;
            this.birthday = birthday;
        }
        public Human(string birthday)
        {
            this.name = "";
            this.surname = "";
            this.birthday = birthday;
        }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Surname
        {
            get { return surname; }
            set
            {
                surname = value;
                OnPropertyChanged("Surname");
            }
        }
        public string Birthday
        {
            get { return birthday; }
            set
            {
                birthday = value;
                OnPropertyChanged("Birthday");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }


    }
}