using System;
using Gtk;

namespace DashCam
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Application.Init();
            Main win = new DashCam.Main();
            win.Show();
            //win.Fullscreen();
            //win.Decorated = false;
            Application.Run();
        }
    }
}
