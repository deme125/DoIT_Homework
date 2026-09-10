using Applictaion.Interfaces;
using Applictaion.Services;
using Domain.Interfaces;
using Domain.Models;
using Repository.Repositories;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=UNIVERSITY;Trusted_Connection=True;TrustServerCertificate=True;";

            IInstructorRepository repository = new InstructorRepository(connectionString);
            IInstructorService service = new InstructorService(repository);

            // 2. Main UI Loop
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("=================================");
                Console.WriteLine("    INSTRUCTOR MANAGEMENT        ");
                Console.WriteLine("=================================");
                Console.WriteLine("1. List All Instructors");
                Console.WriteLine("2. Find Instructor by ID");
                Console.WriteLine("3. Add New Instructor");
                Console.WriteLine("4. Update Instructor");
                Console.WriteLine("5. Delete Instructor");
                Console.WriteLine("6. Exit");
                Console.WriteLine("=================================");
                Console.Write("Select an option (1-6): ");

                string? input = Console.ReadLine();
                Console.Clear();

                switch (input)
                {
                    case "1":
                        ListInstructors(service);
                        break;
                    case "2":
                        GetInstructorById(service);
                        break;
                    case "3":
                        AddInstructor(service);
                        break;
                    case "4":
                        UpdateInstructor(service);
                        break;
                    case "5":
                        DeleteInstructor(service);
                        break;
                    case "6":
                        exit = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Press Any key to try again.");
                        break;
                }

                if (!exit)
                {
                    Console.WriteLine("\nPress Enter to return to the menu...");
                    Console.ReadLine();
                }
            }
        }

        private static void ListInstructors(IInstructorService service)
        {
            Console.WriteLine("--- All Instructors ---");
            var instructors = service.GetInstructors();

            if (!instructors.Any())
            {
                Console.WriteLine("No instructors found.");
                return;
            }

            Console.WriteLine($"{"ID",-5} | {"First Name",-15} | {"Last Name",-15} | {"Email",-25}");
            Console.WriteLine(new string('-', 65));

            foreach (var inst in instructors)
            {
                Console.WriteLine($"{inst.Id,-5} | {inst.FirstName,-15} | {inst.LastName,-15} | {inst.Email,-25}");
            }
        }

        private static void GetInstructorById(IInstructorService service)
        {
            Console.WriteLine("--- Find Instructor ---");
            Console.Write("Enter Instructor ID: ");

            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var inst = service.GetInstructorById(id);
                if (inst != null)
                {
                    Console.WriteLine($"\nID: {inst.Id}");
                    Console.WriteLine($"First Name: {inst.FirstName}");
                    Console.WriteLine($"Last Name: {inst.LastName}");
                    Console.WriteLine($"Email: {inst.Email}");
                }
                else
                {
                    Console.WriteLine($"\nInstructor with ID {id} was not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid ID format.");
            }
        }

        private static void AddInstructor(IInstructorService service)
        {
            Console.WriteLine("--- Add New Instructor ---");
            var instructor = new Instructor();

            Console.Write("First Name: ");
            instructor.FirstName = Console.ReadLine() ?? "";

            Console.Write("Last Name: ");
            instructor.LastName = Console.ReadLine() ?? "";

            Console.Write("Email: ");
            instructor.Email = Console.ReadLine() ?? "";

            try
            {
                bool success = service.CreateInstructor(instructor);
                Console.WriteLine(success ? "\nInstructor created successfully!" : "\nFailed to create instructor.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nValidation Error: {ex.Message}");
            }
        }

        private static void UpdateInstructor(IInstructorService service)
        {
            Console.WriteLine("--- Update Instructor ---");
            Console.Write("Enter ID to update: ");

            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid ID format.");
                return;
            }

            var instructor = service.GetInstructorById(id);
            if (instructor == null)
            {
                Console.WriteLine($"Instructor with ID {id} not found.");
                return;
            }

            Console.WriteLine($"Updating Instructor #{instructor.Id} (Leave blank to keep current value)");

            Console.Write($"First Name [{instructor.FirstName}]: ");
            string? firstName = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(firstName)) instructor.FirstName = firstName;

            Console.Write($"Last Name [{instructor.LastName}]: ");
            string? lastName = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(lastName)) instructor.LastName = lastName;

            Console.Write($"Email [{instructor.Email}]: ");
            string? email = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(email)) instructor.Email = email;

            try
            {
                bool success = service.UpdateInstructor(instructor);
                Console.WriteLine(success ? "\nInstructor updated successfully!" : "\nFailed to update instructor.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nValidation Error: {ex.Message}");
            }
        }

        private static void DeleteInstructor(IInstructorService service)
        {
            Console.WriteLine("--- Delete Instructor ---");
            Console.Write("Enter ID to delete: ");

            if (int.TryParse(Console.ReadLine(), out int id))
            {
                try
                {
                    bool success = service.DeleteInstructor(id);
                    Console.WriteLine(success ? "\nInstructor deleted successfully!" : "\nInstructor not found or could not be deleted.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nError: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Invalid ID format.");
            }
        }
    }
}
