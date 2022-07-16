using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSCourse2022.WPFApp.Lab09.Ex01_DataBindingDemo
{
    public class Student
    {
        public string StudentName { get; set; }
        public bool IsEnrolled { get; set; }
    }
    public class StudentList : ObservableCollection<Student>
    {

    }
}
