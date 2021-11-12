using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Constants
{
    public static partial class Constant
    {
        public static void ThrowIfNull(object obj,string message)
        {
            if (obj is null)
                throw new Exception(message);
        }
        public static void ThrowException(string message) => throw new Exception(message);
        public static string NullParameterMessage=> $"The parameter is null...";
    }
}
