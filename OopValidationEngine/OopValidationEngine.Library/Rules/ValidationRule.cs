using OopValidationEngine.Library.Objects;


namespace OopValidationEngine.Library.Rules
{
    public abstract class ValidationRule
    {
        public abstract bool Validate(IGeneralObject generalObject);
    }
}
