using System;
using System.Text.RegularExpressions;

namespace e12
{
    public static class ExtensionMethods
    {
        public static bool IsUrl(this String str)
        {
            var regex = new Regex("((([A-Za-z]{3,9}:(?:\\/\\/)?)(?:[-;:&=\\+\\$,\\w]+@)?[A-Za-z0-9.-]+|(?:www.|[-;:&=\\+\\$,\\w]+@)[A-Za-z0-9.-]+)((?:\\/[\\+~%\\/.\\w-_]*)?\\??(?:[-\\+=&;%@.\\w_]*)#?(?:[\\w]*))?)");
            return regex.IsMatch(str);
        }
    }
}