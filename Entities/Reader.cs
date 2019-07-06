namespace Entities
{
    public class Reader
    {
        public int Reader_ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Login { get; set; }
        public string Password { get; private set; }

        public Reader()
        { }

        public Reader(string name, string surname, string phone)
        {
            Name = name;
            Surname = surname;
            Phone = phone;
        }

        public override string ToString()
        {
            return $"{Reader_ID}. Name: {Name} Surname: {Surname} Phone: {Phone}";
        }

        public void SetPassword(string newPassword)
        {
            Password = newPassword;
        }

        public void SetLogin(string newLogin)
        {
            Login = newLogin;
        }
    }
}