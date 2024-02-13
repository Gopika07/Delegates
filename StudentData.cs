using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelegatesEvents;

namespace DelegatesEvents
{
    public class StudentData
    {
        public List<StudentModel> StudentList = new List<StudentModel>
        {
            new StudentModel {Id = 100, Name = "Ram", Age = 15, Score = 99},
            new StudentModel {Id = 121, Name = "Arjun", Age = 19, Score = 89.8},
            new StudentModel {Id = 101, Name = "Rahul", Age = 15, Score = 99.9},
            new StudentModel {Id = 102, Name = "Riya", Age = 16, Score = 78.5},
        };
    }
}
