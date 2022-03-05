using OopValidationEngine.Library.Objects;


namespace OopValidationEngine.Library.Rules.MonkeyValidationRules
{
    public abstract class MonkeyValidation : ValidationRule
    {

        public abstract bool ValidateMonkey(MonkeyObject monkey);
        public override bool Validate(IGeneralObject generalObject)
        {
            MonkeyObject monkey = (MonkeyObject)generalObject;

            return ValidateMonkey(monkey);
        }
    }
}
