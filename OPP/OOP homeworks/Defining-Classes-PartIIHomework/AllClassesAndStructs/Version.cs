using System;
using System.Text.RegularExpressions;

namespace AllClassesAndStructs
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class |
       AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method)]

   public class Version :Attribute
    {
        public string Ver
        {
            get;
            private set;
        }

        public Version(string version)
        {
            if (version == null || !Regex.IsMatch(version, @"^\d+\.\d+$"))
            {
                throw new ArgumentException("Invalid version format (major.minor expected).");
            }

            this.Ver = version;
        }
    }
}
