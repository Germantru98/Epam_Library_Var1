namespace Entities
{
    public class ReaderDemo
    {
        public int Reader_ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Login { get; set; }

        public ReaderDemo()
        { }

        public override string ToString()
        {
            return $"{Reader_ID}. Name: {Name} Surname: {Surname} Phone: {Phone}";
        }
        public bool isCorrectState()
        {

            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Surname) || string.IsNullOrEmpty(Phone) || string.IsNullOrEmpty(Login))
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