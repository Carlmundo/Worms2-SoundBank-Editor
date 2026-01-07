using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWARand
{
    public static class LogHandler
    {
        static StringBuilder logBuilder = new StringBuilder();
        public static void Log(string input)
        {
            if (OptionsHandler.options.randomizerLog)
            {
                logBuilder.AppendLine(input);
            }
        }

        public static void SaveLog()
        {
            if (OptionsHandler.options.randomizerLog)
            {
                File.WriteAllText(Program.exeloc + @"\DWARand log.txt", logBuilder.ToString());
                logBuilder.Clear();
            }
        }
    }
}
