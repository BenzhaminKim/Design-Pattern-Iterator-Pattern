using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorLib
{
    public class LunchMenu
    {
        ItemMenu[] items;
        private uint position;
        private const uint _numberOfItems = 30;

        public LunchMenu()
        {
            items = new ItemMenu[_numberOfItems];

            addItemMenu("lunch Item1", "description Item1", 12.3M);
            addItemMenu("lunch Item2", "description Item2", 13.3M);
            addItemMenu("lunch Item3", "description Item3", 14.3M);
            addItemMenu("lunch Item4", "description Item4", 15.3M);
            addItemMenu("lunch Item5", "description Item5", 16.3M);
            addItemMenu("lunch Item6", "description Item6", 17.3M);

        }

        private void addItemMenu(string name, string description, decimal cost)
        {
            ItemMenu itemMenu = new ItemMenu(name, description, cost);
            items[position] = itemMenu;
            position++;
        }

        public ItemMenu[] getMenu()
        {
            return items;
        }
        public Iterator CreateLunchIterator()
        {
            return new LunchIterator(items);
        }
    }
}
