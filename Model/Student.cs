﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Student : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name 
        { 
            get 
            { 
                return _name; 
            } 
            set 
            { 
                _name = value; 
                OnPropertyChanged(nameof(Name)); 
            } 
        }
        private string _name; 
        public string Group 
        { 
            get 
            { 
                return _group; 
            } 
            set 
            { 
                _group = value;
                OnPropertyChanged(nameof(Group)); 
            } 
        }
        private string _group;
        public string Speciality 
        { 
            get 
            { 
                return _speciality; 
            } 
            set 
            { 
                _speciality = value;
                OnPropertyChanged(nameof(Speciality));
            } 
        }
        private string _speciality;
        public Student()
        { }

        public Student(string name, string group, string spec)
        {
            this.Speciality = spec;
            this.Name = name;
            this.Group = group;
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
