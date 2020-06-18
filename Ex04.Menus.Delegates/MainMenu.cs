using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class MainMenu : SubMenu
    {
        protected override void printReturnLine()
        {
            Console.WriteLine("0. Exit");
        }
        public MainMenu(String I_Name) : base(I_Name)
        {

        }
    }
}
