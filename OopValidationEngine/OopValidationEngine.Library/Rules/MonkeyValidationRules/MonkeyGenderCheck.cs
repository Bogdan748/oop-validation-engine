using OopValidationEngine.Library.Objects;


namespace OopValidationEngine.Library.Rules.MonkeyValidationRules
{
    public class MonkeyGenderCheck : MonkeyValidation
    {
        public MonkeyGenderCheck(char gender)
        {
            Gender = gender;
        }
        public char Gender { get; }
        public override bool ValidateMonkey(MonkeyObject monkey)
        {
            return monkey.Gender == Gender;
        }
    }
}
