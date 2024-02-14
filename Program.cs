using DelegatesEvents;

public delegate int Comparison<T>(T x, T y);

class Program
{
    public static void Main()
    {
        StudentData studentData = new StudentData();
        StudentModel[] students = studentData.StudentList.ToArray();

        Comparison<StudentModel> scoreComparison = (student1, student2) =>
        {
            return student1.Score.CompareTo(student2.Score);
        };

        SortData.Sort(students, scoreComparison);

        Console.WriteLine("Sorted Students by Score:");
        foreach (var student in students)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}, Score: {student.Score}");
        }
    }
}

