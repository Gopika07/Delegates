using DelegatesEvents;

//public delegate void ComparisonDelegate<T>(T num);

public delegate int Comparison(StudentModel s1, StudentModel s2);

class Program
{
    public static void Main()
    {
        StudentData studentData = new StudentData();
        var studentList = studentData.StudentList;

        Comparison<StudentModel> studentComparer = new Comparison<StudentModel>(Compare.Sort);

        
        foreach (StudentModel student in studentList)
        {
            Console.WriteLine($"{student.Name}, {student.Id}, {student.Age}");
        }

        studentList.Sort(studentComparer);


        foreach (StudentModel student in studentList)
        {
            Console.WriteLine($"{student.Name}, {student.Id}, {student.Age}");
        }
    }
}

