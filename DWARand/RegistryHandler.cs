using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWARand
{
    public class RegistryHandler
    {
        public static void Initialize()
        {

        }

        public static void Register()
        {
            RegistryKey curUser = Registry.CurrentUser;

            var curUserKey = curUser.OpenSubKey(@"Software\Classes", true);

            var dwarandKey = curUserKey.OpenSubKey(@"dwarand", true);

            if (dwarandKey == null)
            {
                dwarandKey = curUserKey.CreateSubKey("dwarand");
            }

            dwarandKey.SetValue("", "\"URL:dwarand Protocol\"");
            dwarandKey.SetValue("URL Protocol", "\"\"");

            var defaultIconKey = dwarandKey.CreateSubKey("DefaultIcon");
            defaultIconKey.SetValue("", "\"" + System.Reflection.Assembly.GetExecutingAssembly().Location + ",1\"");

            var shellKey = dwarandKey.CreateSubKey("shell");
            var openKey = shellKey.CreateSubKey("open");
            var commandKey = openKey.CreateSubKey("command");
            commandKey.SetValue("", "\"" + System.Reflection.Assembly.GetExecutingAssembly().Location + "\" \"%1\"");
        }

        public static void Unregister()
        {
            RegistryKey curUser = Registry.CurrentUser;

            var curUserKey = curUser.OpenSubKey(@"Software\Classes", true);

            var dwarandKey = curUserKey.OpenSubKey(@"dwarand", true);

            if (dwarandKey != null)
            {
                curUserKey.DeleteSubKeyTree("dwarand");
            }
        }
    }
}
