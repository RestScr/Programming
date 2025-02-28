using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public static class Validator
    {
        public static void AssertOnPositiveValue(double value, string valueName)
        {
            if (value < 0)
            {
                throw new ArgumentException(valueName + " value cannot be below zero");
            }
        }
    }
}
