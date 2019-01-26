using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorLib
{
    public  class LunchIterator : Iterator
    {
        private ItemMenu[] itemMenu;
        private uint position;
        
        public LunchIterator(ItemMenu[] lunchMenuItems)
        {
            itemMenu = lunchMenuItems;
        }
        

        public bool HasNext()
        {
            if(position >= itemMenu.Length || itemMenu[position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public object Next()
        {
            ItemMenu item = itemMenu[position];
            position++;
            return item;
        }
    }
}
