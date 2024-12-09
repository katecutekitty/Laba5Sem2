using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Windows.Input;



namespace ViewModel
{
    public class StudentViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Student> Students { get; set; }
        public RelayCommand AddStudentCommand { get; set; }
        public RelayCommand RemoveStudentCommand { get; set; }

        public StudentViewModel() 
        {
            Students = new ObservableCollection<Student>();
            CurrentStudent = new Student();

            Students.Add(new Student("1", "1", "1"));
            Students.Add(new Student("2", "2", "2"));
            Students.Add(new Student("3", "3", "3"));

            AddStudentCommand =new RelayCommand(AddStudent);
            RemoveStudentCommand = new RelayCommand(RemoveStudent);
        }

        public Student CurrentStudent 
        { 
            get 
            { 
                return _student; 
            } 
            set 
            { 
                _student = value; 
                OnPropertyChanged(nameof(CurrentStudent)); 
            } 
        }
        public Student _student { get; set; }

        private void AddStudent()
        {
            Student s = CurrentStudent;
            Students.Add(s);
            CurrentStudent = new Student();

        }
        private void RemoveStudent()
        {
            Students.Remove(CurrentStudent);
            CurrentStudent = new Student();
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
