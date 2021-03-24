using System;
namespace DashCam
{
    public partial class Main : Gtk.Window
    {
        public Main() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            var pixBuf = global::Gdk.Pixbuf.LoadFromResource("DashCam.U_461_2592x1944.jpg");
            pixBuf = pixBuf.ScaleSimple(540, 400, Gdk.InterpType.Bilinear);
            Preview.Pixbuf = pixBuf;
        }

        protected void Recordings_Click(object sender, EventArgs e)
        {
            Recordings win = new Recordings();
            win.Show();
        }
    }
}
