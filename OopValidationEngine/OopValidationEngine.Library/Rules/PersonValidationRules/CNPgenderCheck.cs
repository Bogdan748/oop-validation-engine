using OopValidationEngine.Library.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopValidationEngine.Library.Rules.PersonValidationRules
{
    public class CNPgenderCheck : PersonValidation
    {
        /// <summary>
        /// Checks if the person's CNP is assignet to a spefic gender
        /// </summary>
        /// <param name="gender">M or F for Masculine or Feminine check</param>
        /// <return>bool value </return>
        public CNPgenderCheck(char gender)
        {
            Gender = gender;
        }

        public char Gender { get; }

        Dictionary<char, char[]> genderChars = new Dictionary<char, char[]> 
            {
                {'M', new char[] { '1', '3','5','7'}},
                {'F', new char[] { '2', '4', '6', '8' }}
            };

        public override bool ValidatePerson(PersonObject person)
        {
            return genderChars[Gender].Contains(person.CNP[0]);
        }
    }

   
}
