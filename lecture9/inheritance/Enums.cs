namespace inheritance
{
    public enum Country
    {
        Georgia = 0,
        Germany,
        France,
        Spain
    }
    public enum Gender
    {
        Male,
        Female
    }
    public enum ContactsType
    {
        Phone,
        Email
    }
    public class Contacts
    {
        public ContactsType Type { get; set; }
        private string value;

        public string Value
        {
            get { return value; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.value = value.Trim();
                }
            }
        }
        public Contacts(ContactsType type, string contactInfo)
        {
            this.Type = type;
            this.Value = contactInfo;
        }
        
    }

}
