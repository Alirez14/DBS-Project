using System;
using System.Windows.Forms;

namespace DBS_GUI {
    static class Program {
        
        // Der Haupteinstiegspunkt für die Anwendung.
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainMenu());
        }
    }
}
