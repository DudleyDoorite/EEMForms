using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEMMain
{
    public class SettingsEventArg : EventArgs
    {
        public SettingsEventArg(string s) { Key = s; }
        public String Key { get; set; } // readonly
    }
}
