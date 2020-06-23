using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MenuAction : MenuItem
    {
        private IMenuItemSelectedListener m_WhenSelectedHandler;

        public MenuAction(string i_Name, IMenuItemSelectedListener i_Listener) : base(i_Name)
        {
            this.m_WhenSelectedHandler = i_Listener;
        }

        public IMenuItemSelectedListener MenuSelectedListener
        {
            get
            {
                return this.m_WhenSelectedHandler;
            }

            set
            {
                this.m_WhenSelectedHandler = value;
            }
        }

        protected internal override void doWhenSelected()
        {
            Console.Clear();
            this.notifySelectedListener();
            Console.WriteLine("Press ENTER to return to the menu");
            Console.ReadLine();
        }

        private void notifySelectedListener()
        {
            this.m_WhenSelectedHandler.DoWhenSelected();
        }
    }
}
