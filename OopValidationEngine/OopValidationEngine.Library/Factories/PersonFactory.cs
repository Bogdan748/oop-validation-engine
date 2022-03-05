using OopValidationEngine.Library.Objects;


namespace OopValidationEngine.Library.Factories
{
    public class PersonFactory : ObjectFactory
    {
        public PersonFactory(
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
        internal override IGeneralObject Create()
        {
            return new PersonObject(LastName, FirstName, CNP, Age);
        }
    }
}
