using System;

namespace Exercise.Utils
{
    public static class NullValidator
    {
        public static void Check(object param, string name)
        {
            if (param == null)
                throw new ArgumentException($"Parameter {name} is null");
        }
    }
}
