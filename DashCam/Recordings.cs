using System;
namespace DashCam
{
    public partial class Recordings : Gtk.Window
    {
        public Recordings() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }
    }
}
