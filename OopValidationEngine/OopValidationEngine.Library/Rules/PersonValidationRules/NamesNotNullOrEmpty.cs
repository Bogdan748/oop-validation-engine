using OopValidationEngine.Library.Objects;
using System;

namespace OopValidationEngine.Library.Rules.PersonValidationRules
{
    public class NamesNotNullOrEmpty : PersonValidation
    {
        public override bool ValidatePerson(PersonObject person)
        {
            return !String.IsNullOrEmpty(person.FirstName) && !String.IsNullOrEmpty(person.LastName);
        }
    }
}
