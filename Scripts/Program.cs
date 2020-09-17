using System;
using System.Windows.Forms;
using System.Reflection;

namespace OsuDesktop
{
    class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
            Application.Run(new WinForm());
            
        }

        static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("OsuDesktop.EmbeddedAssemblies.Newtonsoft.Json.dll");
            var assemblyData = new Byte[stream.Length];
            stream.Read(assemblyData, 0, assemblyData.Length);
            return Assembly.Load(assemblyData);
        }
    }
}
