using OopValidationEngine.Library;
using OopValidationEngine.Library.Factories;
using OopValidationEngine.Library.Rules.PersonValidationRules;
using OopValidationEngine.Library.Rules.MonkeyValidationRules;
using System;

namespace ApplicationTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidationEngine engine = new ValidationEngine(
                new CNPIsStringOfNumbers(),
                new NamesNotNullOrEmpty(),
                new CNPgenderCheck('M'),
                new IsOverAge(20)
                );

            engine.Initialize(new PersonFactory("Popescu", "Dorel", "12345678903", 25));

            Console.WriteLine($"The rezult of the person validation is: {engine.Validate()}");

            Console.WriteLine("----------------------------------");

            ValidationEngine monkeyEngine = new ValidationEngine(
                new MonkeyGenderCheck('M')
                );

           monkeyEngine.Initialize(new MonkeyFactory("Dodo",43,'M'));

            Console.WriteLine($"The rezult of the monkey validation is: {monkeyEngine.Validate()}");

        }
    }
}
