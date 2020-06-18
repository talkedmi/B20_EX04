using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
    internal class interfaceTest
    {
        private MainMenu m_MainMenu;

        private void createMenu()
        {
            m_MainMenu = new MainMenu("Interface Test Menu");
            SubMenu showDateTime = new SubMenu("Show Date/Time");
            MenuAction showTime = new MenuAction("Show Time", new TimeView());
            MenuAction showDate = new MenuAction("Show Date", new DateView());
            SubMenu versionAndCapitals = new SubMenu("Version and Capitals");
            MenuAction countCapital = new MenuAction("Count Capitals", new CountCapitals());
            MenuAction showVersion = new MenuAction("Show Version", new VersionShower());
            m_MainMenu.AddMenuItem(showDateTime);
            m_MainMenu.AddMenuItem(versionAndCapitals);
            showDateTime.AddMenuItem(showTime);
            showDateTime.AddMenuItem(showDate);
            versionAndCapitals.AddMenuItem(countCapital);
            versionAndCapitals.AddMenuItem(showVersion);
        }

        public void Show()
        {
            createMenu();
            m_MainMenu.Show();
        }

    }
}
