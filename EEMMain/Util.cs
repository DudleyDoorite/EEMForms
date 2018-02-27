using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEMMain
{
    public class Util
    {
        public static string GetNextFolder(string folder)
        {
            string ret = string.Empty;
            string lastTwo;
            string firstHalf;
            int LastTwoValue;


            //Get the last 2 char of the folder name passed in.
            if (folder.Length > 2)
            {
                lastTwo = folder.Substring(folder.Length - 2);
                firstHalf = folder.Substring(0, folder.Length - 2);
                try
                {
                    LastTwoValue = int.Parse(lastTwo)+1;
                    ret = string.Format("{0}{1}", firstHalf, LastTwoValue.ToString("00"));
                }
                catch (Exception ex)
                {
                    LastTwoValue = 0;
                    ret = string.Format("{0}{1}", folder, LastTwoValue.ToString("00"));
                }
            }
            else
            {
                ret = string.Format("{0}00", folder);
            }


            return ret;
        }
    }
}
