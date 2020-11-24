using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace WpfLMI
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private Teacher selectedTeacher;
        public ObservableCollection<Teacher> Teacher { get; set; }

        // команда добавления нового объекта
        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand(obj =>
                  {
                      Teacher teacher = new Teacher();
                      Teacher.Insert(0, teacher);
                      SelectedTeacher = teacher;
                  }));
            }
        }

        // команда удаления
        private RelayCommand removeCommand;
        public RelayCommand RemoveCommand
        {
            get
            {
                return removeCommand ??
                  (removeCommand = new RelayCommand(obj =>
                  {
                      Teacher teacher = obj as Teacher;
                      if (teacher != null)
                      {
                          Teacher.Remove(teacher);
                      }
                  },
                 (obj) => Teacher.Count > 0));
            }
        }

        public Teacher SelectedTeacher
        {
            get { return selectedTeacher; }
            set
            {
                selectedTeacher = value;
                OnPropertyChanged("SelectedTeacher");
            }
        }

        public ApplicationViewModel()
        {
            Teacher = new ObservableCollection<Teacher>
            {
                new Teacher { Name="Oksana", Surname="Ivakova", Birthday="03.12.2001", Cathedra="Математика", Posada="Вчитель", Institution_of_higher_education="Політех" },
                new Teacher { Name="Тарас", Surname="Копченко", Birthday="04.04.2000", Cathedra="Фізкультура", Posada="Вчитель", Institution_of_higher_education="Університет" },
                new Teacher { Name="Петро", Surname="Онуфко", Birthday="05.03.1999", Cathedra="Укр мова", Posada="Вчитель", Institution_of_higher_education="Інститут" },
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}