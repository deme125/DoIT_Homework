using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Principal;
using static System.Net.Mime.MediaTypeNames;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] arr =
            {
                new Student("Giorgi", "Beridze", 20, "giorgi.beridze@gmail.com", "555111111", 3.8f, Faculty.IT),
                new Student("Nika", "Kapanadze", 19, "nika.kapanadze@gmail.com", "555222222", 3.5f, Faculty.Business),
                new Student("Luka", "Gelashvili", 21, "luka.gelashvili@gmail.com", "555333333", 3.9f, Faculty.IT),
                new Student("Saba", "Japaridze", 18, "saba.japaridze@gmail.com", "555444444", 3.2f, Faculty.Design),
                new Student("Ana", "Mchedlishvili", 20, "ana.mchedlishvili@gmail.com", "555555555", 4.0f, Faculty.Medicine),
                new Student("Mariam", "Kiknadze", 22, "mariam.kiknadze@gmail.com", "555666666", 3.7f, Faculty.Business),
                new Student("Dato", "Chikovani", 19, "dato.chikovani@gmail.com", "555777777", 3.4f, Faculty.IT),
                new Student("Tornike", "Khutsishvili", 21, "tornike.khutsishvili@gmail.com", "555888888", 3.6f, Faculty.Design),
                new Student("Elene", "Abashidze", 20, "elene.abashidze@gmail.com", "555999999", 3.9f, Faculty.Medicine),
                new Student("Sandro", "Gogoladze", 18, "sandro.gogoladze@gmail.com", "555123456", 3.1f, Faculty.Business)
            };

            while (true)
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Show all students");
                Console.WriteLine("2. Find best student");
                Console.WriteLine("3. Calculate average GPA");
                Console.WriteLine("4. Search student by surname");
                Console.WriteLine("5. Sort students by GPA");
                Console.WriteLine("6. Add student");
                Console.WriteLine("7. Delete student");
                Console.WriteLine("8. Exit");

                bool valid = int.TryParse(Console.ReadLine(), out int choice);
                if (!valid)
                {
                    Console.WriteLine("Invalid input try again!");
                }
                else
                {
                    switch (choice)
                    {
                        case 1:
                            ShowAllStudents(arr);
                            break;
                        case 2:
                            FindBestStudent(arr);
                            break;
                        case 3:
                            CalculateAvarageGPA(arr);
                            break;
                        case 4:
                            SearchByLastName(arr);
                            break;
                        case 5:
                            SortByGPA(arr);
                            break;
                        case 6:
                            arr = AddStudent(arr);
                            break;
                        case 7:
                            arr = RemoveStudent(arr);
                            break;
                        case 8:
                            return;
                        default:
                            Console.WriteLine("invalid choice");
                            break;


                    }
                }
            }
        }
        public static void ShowAllStudents(Student[] students)
        {
            Console.WriteLine("\nAll Students:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        public static void FindBestStudent(Student[] students)
        {
            float maxGPA = float.MinValue;
            int index = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].GPA > maxGPA)
                {
                    maxGPA = students[i].GPA;
                    index = i;
                }
            }
            Console.WriteLine(students[index]);
        }
        public static void CalculateAvarageGPA(Student[] students)
        {
            float sum = 0;
            for (int i = 0; i < students.Length; i++)
            {
                sum += students[i].GPA;
            }
            Console.WriteLine(sum /= students.Length);
        }

        public static void SearchByLastName(Student[] students)
        {
            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine().Trim();
            bool found = false;
            foreach (var student in students)
            {
                if (lastName.ToLower() == student.LastName.ToLower())
                {
                    Console.WriteLine($"found: {student}");
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("student with that lastname can not be searched!");
            }
        }

        public static void SortByGPA(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                for (int j = i + 1; j < students.Length; j++)
                {
                    if (students[i].GPA > students[j].GPA)
                    {
                        Student temp = students[i];
                        students[i] = students[j];
                        students[j] = temp;
                    }
                }
            }
        }

        public static Student[] AddStudent(Student[] students)
        {
            try
            {
                Console.Write("write new students name: ");
                string name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("invalid input, this can not be student's name!");
                    return students;
                }

                Console.Write("write new students last name: ");
                string lastName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(lastName))
                {
                    Console.WriteLine("invalid input, this can not be student's last name!");
                    return students;
                }

                Console.Write("write new students age: ");
                if (!int.TryParse(Console.ReadLine(), out int age) || age < 16 || age > 100)
                {
                    Console.WriteLine("invalid input, this can not be student's age!");
                    return students;
                }

                Console.Write("write new students email: ");
                string email = Console.ReadLine();
                bool validEmail = false;
                for (int i = 0; i < email.Length; i++)
                {
                    if (email[i] == '@')
                    {
                        validEmail = true;
                    }
                }
                if (string.IsNullOrWhiteSpace(email) || !validEmail)
                {
                    Console.WriteLine("invalid input, this can not be student's emial!");
                    return students;
                }

                Console.Write("write new students phone: ");
                string phone = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(phone) || phone.Length != 9)
                {
                    Console.WriteLine("invalid input, this can not be student's phone!");
                    return students;
                }

                Console.Write("write new students GPA: ");
                float.TryParse(Console.ReadLine(), out float gpa);
                if (gpa < 0 || gpa > 4)
                {
                    Console.WriteLine("invalid input, this can not be student's GPA!");
                    return students;
                }

                Console.Write("write faculty (IT, Business, Design, Medicine): ");
                if (!Enum.TryParse(Console.ReadLine(), true, out Faculty faculty))
                {
                    Console.WriteLine("invalid input!");
                    return students;
                }


                Student[] newArr = new Student[students.Length + 1];
                for (int i = 0; i < students.Length; i++)
                {
                    newArr[i] = students[i];
                }
                Student newStudent = new Student(name, lastName, age, email, phone, gpa, faculty);
                newArr[newArr.Length - 1] = newStudent;
                ShowAllStudents(newArr);
                return newArr;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return students;
            }


        }

        public static Student[] RemoveStudent(Student[] students)
        {
            Console.Write("Enter Email of student you want to remove: ");
            string Email = Console.ReadLine().Trim();
            foreach (var student in students)
            {
                if (Email.ToLower() == student.Email.ToLower())
                {
                    Console.WriteLine($"Is this student you are looking for: {student} Y/N");
                    string choice = Console.ReadLine();
                    if (choice.ToLower() == "y")
                    {
                        Student[] newArr = new Student[students.Length - 1];
                        int index = 0;
                        for (int i = 0; i < students.Length; i++)
                        {
                            if (student != students[i])
                            {
                                newArr[index] = students[i];
                                index++;
                            }
                        }
                        ShowAllStudents(newArr);
                        return newArr;
                    }
                    else
                    {
                        Console.WriteLine("Sorry we dont have anyone else with same Email");
                        ShowAllStudents(students);
                        return students;
                    }
                }
            }
            Console.WriteLine("We dont have student with this email");
            ShowAllStudents(students);
            return students;
        }


    }
}
