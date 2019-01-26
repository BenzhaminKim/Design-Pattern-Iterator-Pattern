using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorLib
{
    public class Waitress
    {
        private LunchMenu lunchMenu;

        public Waitress(LunchMenu lunchMenu)
        {
            this.lunchMenu = lunchMenu;
        }
        public void PrintMenu()
        {
            Iterator lunchIterator = lunchMenu.CreateLunchIterator();

            PrintMenu(lunchIterator);
        }

        public void PrintMenu(Iterator iterator)
        {
            while (iterator.HasNext())
            {
                ItemMenu itemMenu = (ItemMenu)iterator.Next();
                Console.WriteLine($"{itemMenu.Name} {itemMenu.Description} {itemMenu.Cost}");
            }
        }
    }
}
