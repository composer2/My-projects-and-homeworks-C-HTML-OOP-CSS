using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingAttributes
{
    class UsingAttributes
    {
        [DllImport("user32.dll", EntryPoint = "MessageBox")]
        public static extern int ShowMessageBox(int hWnd, string text, string caption, int type);
        static void Main(string[] args)
        {
            ShowMessageBox(0, "Some text", "Some caption", 0);
        }
    }
}
