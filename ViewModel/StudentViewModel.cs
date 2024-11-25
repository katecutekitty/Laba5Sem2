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
    public class StudentViewModel
    {
        public ObservableCollection<Student> Students { get; set; }
        public RelayCommand AddStudentCommand { get; set; }
        public RelayCommand RemoveStudentCommand { get; set; }

        public StudentViewModel() 
        {
            Students= new ObservableCollection<Student>();
            CurrentStudent=new Student();

            AddStudentCommand=new RelayCommand(AddStudent);
            RemoveStudentCommand = new RelayCommand(RemoveStudent);


        }

        //public class ObservableCollection<T> : Collection<T>, INotifyCollectionChanged
        //{
        //    public event NotifyCollectionChangedEventHandler CollectionChanged;
        //}

        public Student CurrentStudent { get; set; }
        public Student _student { get; set; }


        public Student CurrentTarget { get; set; }
        public Student _currentTarget { get; set; }

        private void AddStudent()
        {
            CurrentStudent = new Student();
            Students.Add(CurrentStudent);
        }
        private void RemoveStudent()
        {
            
            Students.Remove(CurrentStudent);
        }
    }
}
