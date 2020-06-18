using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class DateView : IMenuItemSelectedListener
    {
        public void DoWhenSelected()
        {
            showDate();
        }

        internal void showDate()
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());
        }
    }
}
