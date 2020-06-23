using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem
    {
        private string m_Name;

        protected MenuItem(string i_Name)
        {
            this.m_Name = i_Name;
        }

        protected string Name
        {
            get
            {
                return this.m_Name;
            }

            set
            {
                m_Name = value;
            }
        }

        protected internal abstract void doWhenSelected();

        public override string ToString()
        {
            return Name;
        }
    }
}
