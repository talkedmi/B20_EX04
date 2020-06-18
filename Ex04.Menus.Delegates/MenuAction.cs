using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public delegate void MenuOptionSelectedDelegate();
     public class MenuAction : MenuItem
    {
        public event MenuOptionSelectedDelegate Selected;

        public MenuAction(string i_Name) : base(i_Name)
        {

        }

        protected internal override void doWhenSelected()
        {
            Console.Clear();
            onSeleced();
            Console.WriteLine("Press enter to return to the menu.");
            Console.ReadLine();
        }

        protected virtual void onSeleced()
        {
            if(Selected != null)
            {
                Selected.Invoke();
            }
            else
            {
                Console.WriteLine("No methods connected to the event");
            }
        }
    }
}
