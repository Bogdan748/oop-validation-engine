using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopValidationEngine.Library.Objects
{
    public class MonkeyObject : IGeneralObject
    {
        public MonkeyObject(
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
    }
}
