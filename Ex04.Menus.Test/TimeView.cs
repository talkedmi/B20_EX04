using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
    public class TimeView : IMenuItemSelectedListener
    {

        public void DoWhenSelected()
        {
            showTime();
        }

        internal void showTime()
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
        }
    }
}
