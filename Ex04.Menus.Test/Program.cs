using System;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            interfaceTest interfaceTest = new interfaceTest();
            DelegatesTest delegatesTest = new DelegatesTest();
            interfaceTest.Show();
            delegatesTest.Show();
        }
    }
}
