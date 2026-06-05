using System.Runtime.InteropServices;

namespace inheritance
{
    public class employ
    {
        private Contacts[] contactInfo;

        private string name;

        private string surname;

        private DateTime birthDate;

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    name = value.Trim();
                }
            }
        }

        public string Surname
        {
            get { return surname; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    surname = value.Trim();
                }
            }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set
            {
                if (value >= DateTime.Today)
                {
                    Console.WriteLine("invalid input you are not born yet!");
                    return;
                }
                else if (DateTime.Today.AddYears(-130) >= value)
                {
                    Console.WriteLine("invalid input you are too old to be alive!");
                    return;
                }
                birthDate = value;
            }
        }

        public Gender Gender { get; set; }
        public Country Country { get; set; }

        public Contacts[] ContactInfo
        {
            get { return contactInfo; }
        }

        public employ(string name,string surname, Country country,Gender gender,DateTime birthdate)
        {
            this.Name = name;
            this.Surname = surname;
            this.Country = country;
            this.Gender = gender;
            this.BirthDate = birthdate;
            this.contactInfo = new Contacts[2];
        }

        public void StoringContact(Contacts value)
        {
            if (value.Type == ContactsType.Phone)
            {
                contactInfo[0] = value;
                Console.WriteLine(ContactInfo[0].Value);
            }
            else if (value.Type == ContactsType.Email)
            {
                contactInfo[1] = value;
                Console.WriteLine(ContactInfo[1].Value);
            }
        }

        public int CalculateAge()
        {
            int age = DateTime.Today.Year - BirthDate.Year;
            //ეს იფ ქონდიშენი ჯერ ადარებს თვეებს თუ დღევანდელი თვე ნაკლებია დაბადების თვეზე
            //ან  თუ თვეები ემთხვევა მაშინ შემდეგში დღეებს ამოწმებს და თუ ან-ის ორივე მხარე მართალია
            //1 წელს გამოაკლებს რადგან წელს მისი დაბადების დღე ჯერ არ ყოფილა
            //(ცოტა უშნოდ დავწერე და ამიტომ მოვაყოლე კომენტარიც)
            if (DateTime.Today.Month < birthDate.Month || (DateTime.Today.Month == birthDate.Month && DateTime.Today.Day < birthDate.Day))
            {
                age -= 1;
            }
            return age;
        }

        public static void FindCountry(employ[] employs, Country country)
        {
            for (int i = 0; i < employs.Length; i++)
            {
                if(employs[i].Country == country)
                {
                    Console.WriteLine($"{employs[i].Name} {employs[i].Surname} is from {country}");
                }
            }
        }


        


	}
}
