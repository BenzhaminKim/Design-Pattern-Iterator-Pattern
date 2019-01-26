using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorLib
{
    public class ItemMenu
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }

        public ItemMenu(string name, string description, decimal cost)
        {
            Name = name;
            Description = description;
            Cost = cost;
        }
    }
}
