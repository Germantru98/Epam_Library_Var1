namespace Entities
{
    public class Reader
    {
        public int Reader_ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public Reader()
        { }

        public Reader(string name, string surname, string phone)
        {
            Name = name;
            Surname = surname;
            Phone = phone;
        }

        public Reader(string name, string surname, string phone, string login, string password)
        {
            Name = name;
            Surname = surname;
            Phone = phone;
            Login = login;
            Password = password;
        }

        public override string ToString()
        {
            return $"{Reader_ID}. Name: {Name} Surname: {Surname} Phone: {Phone}";
        }

        public bool isCorrectState()
        {
            if ((string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Surname) || string.IsNullOrEmpty(Phone) || string.IsNullOrEmpty(Login)))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}