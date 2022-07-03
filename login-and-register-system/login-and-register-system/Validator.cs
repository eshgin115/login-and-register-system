using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Validator
    {
        public bool IsCheckLentgh(string value, int start, int end)
        {
            return (value.Length > start && value.Length < end);
        }
        public bool IsCheckChar(string mail)
        {
            for (int i = 0; i < mail.Length; i++)
            {
                if (mail[i] == '@')
                {
                    return true;
                }
            }
            return false;
        }
    }
}
