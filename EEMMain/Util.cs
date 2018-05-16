using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


        public static DialogResult DisplayWarningMessage(string msg)
        {
            string caption = "Warning Message";
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            // Displays the MessageBox and return the results.
            return DisplayMessageWindow(msg, caption, buttons);
        }

        public static DialogResult DisplayErrorMessage(string msg)
        {
            string caption = "Error Message";
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            // Displays the MessageBox and return the results.
            return DisplayMessageWindow(msg, caption, buttons);
        }

        private static DialogResult DisplayMessageWindow(string message, string caption, MessageBoxButtons buttons)
        {
            return MessageBox.Show(message, caption, buttons);
        }

        public static void OpenFolder(string folder)
        {
            if (Directory.Exists(folder))
            {
                System.Diagnostics.Process.Start(folder);
            }
            else
            {
                Util.DisplayErrorMessage(string.Format("Folder Not Found.\n {0}", folder));

            }
        }

    }
}
