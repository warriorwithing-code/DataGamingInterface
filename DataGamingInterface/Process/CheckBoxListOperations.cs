using Aplication.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.CheckedListBox;

namespace DataGamingInterface.Process
{
    public class CheckBoxListOperations
    {
        AplicationProcess aplicationProcess = new AplicationProcess();

        public string Roll_Dice(List<string> items)
        {
            return aplicationProcess.Roll_Dice(items);
        }
    }
}
