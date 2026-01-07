using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWARand
{
    public class ProtVar
    {
        public string varName;
        public List<string> varValue = new List<string>();

        public ProtVar(string varname, string varvalue)
        {
            varName = varname;

            if (varvalue.Contains(Program.bankSep))
            {
                var values = varvalue.Split(new string[] { Program.bankSep }, StringSplitOptions.None);

                foreach (var item in values)
                {
                    varValue.Add(item);
                }
            }
            else
            {
                varValue.Add(varvalue);
            }
        }
    }
}
