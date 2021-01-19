using System;
using System.Collections.Generic;
using System.Text;
using Gtk;

namespace TestGTKUI
{
    public class testWindow : Window
    {
        private Builder builder;
        public static testWindow Create()
        {
            Builder _builder = new Builder(null, "TestGTKUI.gladefiles.test.glade", null);
            return new testWindow(_builder, _builder.GetObject("testWindow").Handle);
        }
        protected testWindow(Builder _builder, IntPtr handle) : base(handle)
        {
            builder = _builder;
            builder.Autoconnect(this);
            Console.WriteLine("testWindow is created");
        }

        private void on_buttonClickme_clicked(object sender, EventArgs e)
        {
            Console.WriteLine("Button clicked");
        }
    }
}
