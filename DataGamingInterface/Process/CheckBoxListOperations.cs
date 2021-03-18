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

        public string Roll_Dice(ObjectCollection items)
        {
            if (items.Count >0)
            {
                var rand = new Random();
                int i = rand.Next(items.Count);
                return items[i].ToString();
            }
            return "";
        }
    }
}
