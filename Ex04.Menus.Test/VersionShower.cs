using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
    public class VersionShower : IMenuItemSelectedListener
    {
        public void DoWhenSelected()
        {
            showVersion();
        }

        internal void showVersion()
        {
            Console.WriteLine("Version : 18.2.4.0");
        }
    }
}
