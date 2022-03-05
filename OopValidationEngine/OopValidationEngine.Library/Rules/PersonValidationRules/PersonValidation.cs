using OopValidationEngine.Library.Objects;


namespace OopValidationEngine.Library.Rules.PersonValidationRules
{
    public abstract class PersonValidation : ValidationRule
    {
        
        public abstract bool ValidatePerson(PersonObject person);
        public  override bool Validate(IGeneralObject generalObject)
        {
            PersonObject person = (PersonObject)generalObject;

            return ValidatePerson(person);
        }
    }
}
