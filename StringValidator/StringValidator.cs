/*
 *String validator
	- validate based on length, pattern, nullablity, empty string
 */


using System;

namespace ConsoleApp3
{
    //Strategy pattern  - Inversion of control concept
    public class StringValidator
    {
        public bool Validate(string str, IStringValidator stringValidator)
        {
            return stringValidator.Validate(str);
        }
    }

    public interface IStringValidator
    {
        bool Validate(string str);
    }

    public class NotNullValidator : IStringValidator 
    {
        public bool Validate(string str)
        {
            return str != null;
        }
    }

    public class RangeValidator : IStringValidator
    {
        private int min, max;

        public RangeValidator(int min, int max)
        {
            this.min = min;
            this.max = max;
        }
        public bool Validate(string str)
        {
            return str.Length >= min && str.Length <= max;
        }
    }



}
