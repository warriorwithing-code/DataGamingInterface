using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.CheckedListBox;

namespace Domain
{
    public class SelectGameLogic : ISelectGameLogic
    {
        public string Roll_Dice(List<string> items)
        {
            if (items.Count > 0)
            {
                var rand = new Random();
                int i = rand.Next(items.Count);
                return items[i];
            }
            return "Error";
        }
    }
}
