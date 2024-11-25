using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Student : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        public string Name { get; set; }
        public string _name;
        
        public string Group { get; set; }
        
        public string Speciality { get; set; }
       
    }
}
