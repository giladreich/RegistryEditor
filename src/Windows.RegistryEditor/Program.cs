using System;
using System.Windows.Forms;
using Windows.RegistryEditor.Views;

namespace Windows.RegistryEditor
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
