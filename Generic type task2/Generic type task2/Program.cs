using System;

class Program
{
    static void Main(string[] args)
    {

        Student student1 = new Student("musayev", true, false);

        Student student = new Student("Mahir", true, true);
        CheckStudents(student1);
        CheckStudents(student);




        static void CheckStudents(Student student)
        {
            if (!student.IsPlagiated || !student.IsHelpedToPlagiate)
            {
                Lion lion = new Lion();
                lion.Parçalamaq(student);
            }
            else
            {
                Console.WriteLine($"{student.Name}  kocurmediyi ucun tohmet verilmez");
            }
        }
    }
}


class Student
{
    public string Name { get; set; }
    public bool IsPlagiated { get; set; }
    public bool IsHelpedToPlagiate { get; set; }
    public Student(string name, bool isplagiated, bool ishelptoplagiated)
    {
        Name = name;
        IsPlagiated = isplagiated;
        IsHelpedToPlagiate = ishelptoplagiated;
    }
}

class Lion
{
    public void Parçalamaq(Student student)
    {
        Console.WriteLine($"{student.Name}  tohmet verildi");
    }
}
