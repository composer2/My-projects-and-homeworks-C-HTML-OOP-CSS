using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticPropertyAccess
{
    public class SystemInfo
    {
        private static double version = 0.1;
        private static string vendor = "Microsoft";
        // The "version" static property
        public static double Version
        {
            get { return version; }
            set { version = value; }
        }
        // The "vendor" static property
        public static string Vendor
        {
            get { return vendor; }
            set { vendor = value; }
        }

        static void Main(string[] args)
        {
            SystemInfo sysInfoInstance = new SystemInfo();
            // Console.WriteLine("System version: " + sysInfoInstance.Version); //compilation error

            // Invocation of static property setter
            SystemInfo.Vendor = "Microsoft Corporation";
            // Invocation of static property getters
            Console.WriteLine("System version: " + SystemInfo.Version);
            Console.WriteLine("System vendor: " + SystemInfo.Vendor);
        }
    }
}
