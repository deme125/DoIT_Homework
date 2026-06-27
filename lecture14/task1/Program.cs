

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            Dictionary<string, int> studentInfo = new Dictionary<string, int>();


            while (true)
            {
                Console.WriteLine("1.Add student");
                Console.WriteLine("2.Search student");
                Console.WriteLine("3.update student");
                Console.WriteLine("4.show all student");
                Console.WriteLine("5.exit");

                bool validChoice = int.TryParse(Console.ReadLine(), out int choice);
                if (!validChoice || choice < 1 || choice > 5)
                {
                    throw new ArgumentException("invalid choice it enter number through 1 to 5");
                }
                switch (choice)
                {
                    case 1:
                        AddStudent(names, studentInfo);
                        break;
                    case 2:
                        SearchStudent(names, studentInfo);
                        break;
                    case 3:
                        UpdateStudent(names, studentInfo);
                        break;
                    case 4:
                        ShowAllStudents(names, studentInfo);
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine();
                        break;
                }

            }
        }
        public static void AddStudent(List<string> names, Dictionary<string, int> studentInfo)
        {
            Console.WriteLine("Enter student name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter student score:");
            bool validScore = int.TryParse(Console.ReadLine(), out int score);
            if (!validScore || score < 0)
            {
                throw new ArgumentException("invalid score");
            }
            names.Add(name);
            studentInfo[name] = score;
            Console.WriteLine("Student added successfully.");
        }
        public static void SearchStudent(List<string> names, Dictionary<string, int> studentInfo)
        {
            Console.WriteLine("Enter student name to search:");
            string name = Console.ReadLine();
            if (names.Contains(name))
            {
                Console.WriteLine($"Student found: {name}, score: {studentInfo[name]}");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }
        public static void UpdateStudent(List<string> names, Dictionary<string, int> studentInfo)
        {
            Console.WriteLine("Enter student name to update:");
            string name = Console.ReadLine();
            if (names.Contains(name))
            {
                Console.WriteLine("Enter new score:");
                bool validScore = int.TryParse(Console.ReadLine(), out int newScore);
                if (!validScore || newScore < 0)
                {
                    throw new ArgumentException("invalid score");
                }
                studentInfo[name] = newScore;
                Console.WriteLine("Student updated successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }
        public static void ShowAllStudents(List<string> names, Dictionary<string, int> studentInfo)
        {
            Console.WriteLine("All Students:");
            foreach (var name in names)
            {
                Console.WriteLine($"Name: {name}, score: {studentInfo[name]}");
            }
        }
    }
}
