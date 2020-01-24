using System;
using System.Collections.Generic;

//Strategy pattern for IOC

namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            var validator = new StringValidator();
            var result = validator.Validate(null, new NotNullValidator());

            Console.WriteLine(result);

            var customValidator = new CustomStringValidator();
            customValidator.Add(new NotNullValidator());
            customValidator.Add(new RangeValidator(0,1024));

            result = validator.Validate("NotNullString", new NotNullValidator());
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }

    //Composite pattern
    public class CustomStringValidator : IStringValidator
    {
        private List<IStringValidator> validators = new List<IStringValidator>();

        public void Add(IStringValidator validator)
        {
            validators.Add(validator);
        }

        public bool Validate(string str)
        {
            var result = true;

            foreach (var validator in validators)
            {
                result &= validator.Validate(str);
            }

            return result;
        }
    }

}
