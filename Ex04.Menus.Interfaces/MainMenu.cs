using System;


namespace Ex04.Menus.Interfaces
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
