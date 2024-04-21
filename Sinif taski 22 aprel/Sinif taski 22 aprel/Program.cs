namespace Sinif_taski_22_aprel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group ab106 = new("AB106");
            Group ab105 = new("AB105");

            List<Student> students = new();
            students.Add(new Student("Ibrahim", "Khushmandi", 20, 200, ab106));
            students.Add(new Student("Garib", "Garibzada", 20, 300, ab106));
            students.Add(new Student("Shahin", "Alizada", 20, 400, ab105));
            students.Add(new Student("Nurlan", "Abbasov", 19, 160, ab106));

            //students.FindAll(s => s.Group == ab106)
            //    .ForEach(s => Console.WriteLine(s.Id + " " + s.Name));
            // students.FindAll(s => s.Credits > 300)
            //.ForEach(s => Console.WriteLine(s.Id +" "+ s.Name));
            //students.ForEach(s=> Console.WriteLine(s.Name +" "+s.Surname));
            //students.FindAll(s=>s.Name.ToLower().Contains("b"))
            // .ForEach(s=> Console.WriteLine(s.Id +" " + s.Name));
            // foreach(Student s in students.OrderBy(s => s.Credits))
            //     {
            //     Console.WriteLine(s.Id + " " + s.Name);
            // }
        }
    }
}
class Group
{
    static int _count = 1;
    public int Id { get; }
    public string Name { get; set; }
    public Group(string name)
    {
        Id = _count++;
        Name = name;
    }
}
class Student
{
    static int _count = 1;
    public int Id { get; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public int Credits { get; set; }
    public Group Group { get; set; }
    public Student(string name, string surname, int age, int credits, Group group)
    {
        Id = _count++;
        Name = name;
        Surname = surname;
        Age = age;
        Credits = credits;
        Group = group;
    }
}