
namespace OopValidationEngine.Library.Objects
{
    public class PersonObject : IGeneralObject 
    {
        public PersonObject(
            string lastName,
            string firstName,
            string cnp,
            int age)
        {
            LastName = lastName;
            FirstName = firstName;
            CNP = cnp;
            Age = age;
        }
        public string LastName { get; }
        public string FirstName { get; }
        public string CNP { get; }
        public int Age { get; }
    }
}
