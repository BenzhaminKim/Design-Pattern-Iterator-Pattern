using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorLib;

namespace IteratorPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            LunchMenu lunchMenu = new LunchMenu();

            Waitress waitress = new Waitress(lunchMenu);
            waitress.PrintMenu();
        }
    }
}
