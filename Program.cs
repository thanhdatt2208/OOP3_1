using static OOP3_1;

public class OOP3_1
{
    public class Human
    {
        private string name;
        public string place_of_birth;
        public DateTime birthday;
        public string Name { get => name; set => name = value; }
        public string Place_of_birth { get => place_of_birth; set => place_of_birth = value; }
        public DateTime Birthdya { get => birthday; set => birthday = value; }
        public Human()
        {
            name = "none";
            place_of_birth = "none";
            birthday = new DateTime(2005, 1, 18);
        }
        public Human (string name_, string place_of_birth_, DateTime birthday_)
        {
            name = name_;
            place_of_birth = place_of_birth_;
            birthday = birthday_;
        }
        public void show_info()
        {
            Console.Write($"{name} \t| {place_of_birth} \t\t\t| {birthday.ToShortDateString()} \t| ");
        }

    }
    public class Student:Human
    {
        public string id;
        public float gpa;
        public string Id { get => id; set => id = value; }
        public float Gpa { get => gpa; set => gpa = value; }
        public Student()
        {
            id = "0";
            gpa = 0;
        }
        public Student (string name, string place_of_birth, DateTime birthday, string id_, float gpa_) : base(name, place_of_birth, birthday)
        {
            id = id_;
            gpa = gpa_;
        }
        public void display_info()
        {
            
            Console.Write($"{id} \t| ");
            base.show_info();
            Console.WriteLine($"{gpa}");
        }
    }

}
class Program
{
    static void SortArray(Student[] students)
    {
        Array.Sort(students, (st1, st2) => st2.gpa.CompareTo(st1.gpa));
    }
    static void Main(string[] args)
    {
        Student[] students = new Student[5]
        {
            new Student("Dat", "HCM", new DateTime(2005,8,22), "01", 9.4f),
            new Student("Bao", "HN", new DateTime(2005,6,8), "02", 9),
            new Student("Tran", "DN", new DateTime(2005,12,24), "03", 9.6f),
            new Student("Nghi", "HCM", new DateTime(2005,1,5), "04", 9.2f),
            new Student("Tuan", "HN", new DateTime(2005,1,18), "05", 9.1f)
        };
        SortArray(students);
        Console.WriteLine("ID \t| Name \t| Place of birth \t| Birthday \t| GPA");
        foreach (Student student in students)
        {
            student.display_info();
        }
    }
}
