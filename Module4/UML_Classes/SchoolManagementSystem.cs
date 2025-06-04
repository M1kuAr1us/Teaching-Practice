namespace UML_Classes;

public class SchoolManagementSystem
{
    static public void SchoolManagementSystemMain()
    {
        Teacher teacher = new Teacher()
        {
            TeacherName = "Teacher",
            LastName = "Teacher",
            Name = "Math"
        };
        
        Classroom classroom = new Classroom()
        {
            Name = "2P-23",
        };
        
        Student student1 = new Student()
        {
            Name = "John",
            LastName = "Doe",
            DateOfBirth = DateTime.Now,
            Classroom = classroom
        };
        
        classroom.AddStudent(student1);
        classroom.Marks.Add(teacher.Rate(11, student1.Name));
        classroom.Marks.Add(teacher.Rate(8, student1.Name));
        classroom.Marks.Add(teacher.Rate(10, student1.Name));
        classroom.Marks.Add(teacher.Rate(9, student1.Name));
        
        List<Mark> student1Marks = student1.GetMarks(student1, classroom.Marks);
        Console.WriteLine($"{student1.Name} marks:");
        foreach (Mark mark in student1Marks)
        {
            Console.Write($"{mark.Value} ");
        }
    }
}

public class Student
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Classroom Classroom { get; set; }

    public List<Mark> GetMarks(Student student, List<Mark> marks)
    {
        List<Mark> studentMarks = new List<Mark>();
        foreach (Mark mark in marks)
        {
            if (mark.StudentName == student.Name)
            {
                studentMarks.Add(mark);
            }
        }
        
        return studentMarks;
    }
}

public class Classroom
{
    public string Name { get; set; }
    public List<Student> StudentList { get; set; } = new List<Student>();
    public List<Mark> Marks { get; set; } = new List<Mark>();

    public void AddStudent(Student student)
    {
        StudentList.Add(student);
    }

    public void RemoveStudent(Student student)
    {
        StudentList.Remove(student);
    }
}

public class Mark
{
    public int Value { get; set; }
    public string StudentName { get; set; }
    public string SubjectName { get; set; }
    public DateTime Date { get; set; }
}

public class Subject
{
    public string Name { get; set; }
}

public class Teacher : Subject
{
    public string TeacherName { get; set; }
    public string LastName { get; set; }

    public Mark Rate(int value, string student)
    {
        Mark mark = new Mark()
        {
            Value = value,
            StudentName = student,
            SubjectName = Name,
            Date = DateTime.Now
        };
        
        return mark;
    }
}