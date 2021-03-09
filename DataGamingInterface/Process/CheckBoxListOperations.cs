using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGamingInterface.Process
{
    public class CheckBoxListOperations
    {
        List<string> items = new List<string>();

        public void addItem()
        {

        }

        public List<string> addItemList()
        {
            items.Add("Warhammer2 Total war");
            items.Add("Mordhau");
            items.Add("Age of empires");
            items.Add("Soulstorm");
            return items;
        }
    }
}
