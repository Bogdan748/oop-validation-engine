using OopValidationEngine.Library.Factories;
using OopValidationEngine.Library.Objects;
using OopValidationEngine.Library.Rules;


namespace OopValidationEngine.Library
{
    public class ValidationEngine
    {
        private static IGeneralObject[] generalObjects;
        public ValidationRule[] Rules { get; }

        public void Initialize(params ObjectFactory[] factories)
        {
            ValidationEngine.generalObjects = new IGeneralObject[factories.Length];
            for (int i = 0; i < factories.Length; i++)
            {
                ValidationEngine.generalObjects[i] = factories[i].Create();
            }
        }

        public ValidationEngine(params ValidationRule[] rules)
        {
            Rules = rules;
        }
        

        public bool Validate()
        {
            foreach(IGeneralObject generalObject in ValidationEngine.generalObjects)
            {
                foreach (ValidationRule rule in Rules)
                {
                    if (!rule.Validate(generalObject))
                    {
                        return false;
                    }
                }
            }
            return true;

        }
    }
}
