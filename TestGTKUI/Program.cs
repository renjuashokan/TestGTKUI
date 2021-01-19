using System;
using Gtk;
using System.Threading.Tasks;
using System.Reflection;

namespace TestGTKUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var assemblyName = new AssemblyName("TestGTKUI");
            var resources = string.Join(Environment.NewLine, Assembly.Load(assemblyName).GetManifestResourceNames());
            Console.WriteLine("List of Manifest Resource Names");
            Console.WriteLine("======================");
            Console.WriteLine(resources);
            GladeApp(args);
        }
        public static void GladeApp(string[] args)
        {
            Application.Init();
            var cssProvider = new CssProvider();
            cssProvider.LoadFromResource("TestGTKUI.cssfiles.main.css");
            //cssProvider.LoadFromPath("main.css");
            Gtk.StyleContext.AddProviderForScreen(Gdk.Screen.Default, cssProvider, Gtk.StyleProviderPriority.User);

            Console.WriteLine("Creating window now");
            testWindow twindow = testWindow.Create();
            twindow.ShowAll();
            Application.Run();
        }
    }
}
