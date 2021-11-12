using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Constants
{
    public static partial class Constant
    {
        public static void ThrowIfStackIsNull() => throw new Exception("The stack is null...");
        public static string StackIfNullThrowWhenPop => "You can't operate Pop() on null stack..";

    }
}
