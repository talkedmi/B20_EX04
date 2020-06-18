using System;

namespace Ex04.Menus.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            interfaceTest interfaceTest = new interfaceTest();
            DelegatesTest delegatesTest = new DelegatesTest();
            interfaceTest.Show();
            delegatesTest.Show();
        }
    }
}
