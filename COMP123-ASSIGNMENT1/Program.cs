using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_ASSIGNMENT1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suggest a name for your hero !!!");
            String name = Console.ReadLine(); 

            //---Instantiating an object for Hero class---------------------
            Hero hero = new Hero(name);

            //---Calling show() and fight() methods ------------------------
            hero.show();
            hero.fight();

            Console.WriteLine("Press any key to exit!!!");
            Console.ReadKey();
        }
    }
}
