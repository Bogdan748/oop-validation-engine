using OopValidationEngine.Library.Objects;
using System;


namespace OopValidationEngine.Library.Rules.PersonValidationRules
{
    public class CNPIsStringOfNumbers : PersonValidation
    {
        
        public override bool ValidatePerson(PersonObject person)
        {
            foreach (char caracter in person.CNP)
            {
                if (!Char.IsNumber(caracter))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
