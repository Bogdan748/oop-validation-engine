using OopValidationEngine.Library.Objects;

namespace OopValidationEngine.Library.Rules.PersonValidationRules
{
    public class IsUnderAge : PersonValidation
    {
        public IsUnderAge(int age)
        {
            Age = age;
        }
        public int Age { get; }
        public override bool ValidatePerson(PersonObject person)
        {
            return person.Age < Age;
        }
    }
}
