using OopValidationEngine.Library.Objects;


namespace OopValidationEngine.Library.Factories
{
    public class MonkeyFactory : ObjectFactory
    {
        /// <summary>
        /// Monkey object generator
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="gender">Char of 'M' for masculine and 'F' for feminine</param>
        public MonkeyFactory(
            string name,
            int age,
            char gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
        public string Name { get; }
        public int Age { get; }
        public char Gender { get; }

        
        internal override IGeneralObject Create()
        {
            return new MonkeyObject(Name,Age,Gender);
        }
    }
}
