using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COCOMO
{
    static class Program
    {
        public static ProjectType organic = new ProjectType(3.2, 1.05, 2.5, 0.38, "Organic");
        public static ProjectType semidetached = new ProjectType(3, 1.12, 2.5, 0.35, "Semi-Detached");
        public static ProjectType embeded = new ProjectType(2.8, 1.20, 2.5, 0.32, "Embeded");
        public static ProjectType project = new ProjectType();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
