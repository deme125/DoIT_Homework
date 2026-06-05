using System.ComponentModel.DataAnnotations;

namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            employ e1 = new employ(
                "Deme", 
                "Sheklashvili",
                Country.Georgia, 
                Gender.Male, 
                new DateTime(2006, 12, 5)
                );
            employ e2 = new employ(
                "Sandro",
                "Sheklashvili",
                Country.Georgia,
                Gender.Male,
                new DateTime(2005, 12, 5)
                );
            employ e3 = new employ(
                "Dea",
                "Sheklashvili",
                Country.Germany,
                Gender.Female,
                new DateTime(2004, 12, 5)
                );
            employ e4 = new employ(
                "Nini",
                "Sheklashvili",
                Country.Germany,
                Gender.Female,
                new DateTime(2003, 12, 5)
                );
            employ e5 = new employ(
                "Gio",
                "Sheklashvili",
                Country.France,
                Gender.Male,
                new DateTime(2002, 12, 5)
                );
            employ e6 = new employ(
                "Mari",
                "Sheklashvili",
                Country.France,
                Gender.Female,
                new DateTime(2001, 12, 5)
                );
            employ e7 = new employ(
                "Luka",
                "Sheklashvili",
                Country.Spain,
                Gender.Male,
                new DateTime(2000, 12, 5)
                );
            employ e8 = new employ(
                "Taso",
                "Sheklashvili",
                Country.Spain,
                Gender.Female,
                new DateTime(2007, 12, 5)
                );

            employ[] employees = new employ[8];

            employees[0] = e1;
            employees[1] = e2;
            employees[2] = e3;
            employees[3] = e4;
            employees[4] = e5;
            employees[5] = e6;
            employees[6] = e7;
            employees[7] = e8;

            employ.FindCountry(employees, Country.Georgia);
            employ.FindCountry(employees, Country.Germany);
            employ.FindCountry(employees, Country.France);
            employ.FindCountry(employees, Country.Spain);

            Console.WriteLine(e1.CalculateAge());
            Console.WriteLine(e2.CalculateAge());
            Console.WriteLine(e3.CalculateAge());
            Console.WriteLine(e4.CalculateAge());
            Console.WriteLine(e5.CalculateAge());
            Console.WriteLine(e6.CalculateAge());
            Console.WriteLine(e7.CalculateAge());
            Console.WriteLine(e8.CalculateAge());


            e1.StoringContact(new Contacts(ContactsType.Phone, "029-384-721"));
            e2.StoringContact(new Contacts(ContactsType.Phone, "784-092-001"));
            e3.StoringContact(new Contacts(ContactsType.Phone, "872-623-123"));
            e4.StoringContact(new Contacts(ContactsType.Phone, "921-612-743"));
            e5.StoringContact(new Contacts(ContactsType.Phone, "101-223-441"));
            e6.StoringContact(new Contacts(ContactsType.Phone, "777-231-678"));
            e7.StoringContact(new Contacts(ContactsType.Phone, "392-102-122"));
            e8.StoringContact(new Contacts(ContactsType.Phone, "991-001-110"));

            Console.ReadKey(); 

        }
    }
}
