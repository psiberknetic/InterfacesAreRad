using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Common.Extensions
{
    public static class NameUtilities
    {
        public static Name ParseName(string name)
        {
            name = name.Replace(".", String.Empty);
            var nameParts = name.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            switch (nameParts.Length)
            {
                case 1:
                    return new Name(nameParts[0], String.Empty, String.Empty);
                case 2:
                    return new Name(nameParts[0], String.Empty, nameParts[1]);
                case 3:
                    return new Name(nameParts[0], nameParts[1], nameParts[2]);
            }

            return null;
        }
    }
}
