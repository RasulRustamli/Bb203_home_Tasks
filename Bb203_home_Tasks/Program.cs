namespace Bb203_home_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
        


            Student[] students = new Student[0];
            int[] ids=new int[0];
            while(true)
            {
                Console.WriteLine("Davam etmek isteyirsinizmi Y/N");
                string input = Console.ReadLine();
                if (input == "Y" || input == "y")
                {


                    Console.WriteLine("Enter Student Name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Student Surname");
                    string surname = Console.ReadLine();
                    Console.WriteLine("Enter Student Id");
                    string id = Console.ReadLine();
                    int newId;
                    bool result = int.TryParse(id, out newId);
                    if (result)
                    {
                        Student student = new Student(name, surname, newId);
                        Array.Resize(ref students, students.Length + 1);
                        students[students.Length - 1] = student;
                        Array.Resize(ref ids, ids.Length+1);
                        ids[ids.Length-1] = newId;
                    }
                    else
                    {
                        Console.WriteLine("Duzgun inputlar daxil edin");
                    }
                }
                else
                {
                    break;
                }
            }
            Array.Sort(ids);
            foreach (var item in ids)
            {
                foreach (var student in students)
                {
                    if(item==student.Id)
                    {
                        Console.WriteLine(student.UserName+""+student.Id);
                    }
                }
            }

        }
    }
}