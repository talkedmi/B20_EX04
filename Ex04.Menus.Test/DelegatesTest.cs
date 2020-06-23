using System;
using System.Text;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    internal class DelegatesTest
    {
        private MainMenu m_MainMenu;

        private MainMenu MainMenu
        {
           get
            {
                return this.m_MainMenu;
            }

            set
            {
                this.m_MainMenu = value;
            }
        }

        private void createMenu()
        {
            MainMenu = new MainMenu("Delegates Test Menu");
            SubMenu showDateTime = new SubMenu("Show Date/Time");
            MenuAction showTime = new MenuAction("Show Time");
            MenuAction showDate = new MenuAction("Show Date");
            SubMenu versionAndCapitals = new SubMenu("version and capitals");
            MenuAction countCapital = new MenuAction("Count Capitals");
            MenuAction showVersion = new MenuAction("Show Version");
            MainMenu.AddMenuItem(showDateTime);
            MainMenu.AddMenuItem(versionAndCapitals);
            showDateTime.AddMenuItem(showTime);
            showDateTime.AddMenuItem(showDate);
            versionAndCapitals.AddMenuItem(showTime);
            versionAndCapitals.AddMenuItem(showDate);
            showTime.Selected += new DateView().showDate;
            showTime.Selected += new TimeView().showTime;
            countCapital.Selected += new CountCapitals().capitalsCounter;
            showVersion.Selected += new VersionShower().showVersion;
        }

        public void Show()
        {
            createMenu();
            MainMenu.Show();
        }
    }
}
