using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COCOMO
{
    static class Program
    {
        public static Cost_Drivers swReliability = new Cost_Drivers(0.75, 0.88, 1.00, 1.15, 1.40, 0.00, "swReliability");
        public static Cost_Drivers sizeofappDatabase = new Cost_Drivers(0.00,0.94,1.00,1.08,1.16,0.00 ,"sizeofappDatabase");
        public static Cost_Drivers productComplexity = new Cost_Drivers(0.70,0.85,1.00,1.15,1.30,1.65, "productComplexity");
        public static Cost_Drivers runtimePerformance = new Cost_Drivers(0.00,0.00,1.00,1.11,1.30,1.66, "runtimePerformance");
        public static Cost_Drivers memoryConstraints = new Cost_Drivers(0.00, 0.00, 1.00, 1.06, 1.21, 1.56, "memoryConstraints");
        public static Cost_Drivers volatilityEnvironment = new Cost_Drivers(0.00,0.87,1.00,1.15,1.30,0.00, "volatilityEnvironment");
        public static Cost_Drivers requiredTime = new Cost_Drivers(0.00,0.87,1.00,1.07,1.15,0.00, "requiredTime");
        public static Cost_Drivers analysitCapability = new Cost_Drivers(1.46,1.19,1.00,0.86,0.71,0.00, "analysitCapability");
        public static Cost_Drivers applicationExperience = new Cost_Drivers(1.29,1.13,1.00,0.91,0.82,0.00, "applicationExperience");
        public static Cost_Drivers sweCpability = new Cost_Drivers(1.42,1.17,1.00,0.86,0.70,0.00, "sweCpability");
        public static Cost_Drivers virtualmachine = new Cost_Drivers(1.21,1.10,1.00,0.90,0.00,0.00, "virtualmachine");
        public static Cost_Drivers programmingLanguage = new Cost_Drivers(1.14,1.07,1.00,0.95,0.00,0.00, "programmingLanguage");
        public static Cost_Drivers appMethods = new Cost_Drivers(1.24,1.10,1.00,0.91,0.82,0.00, "appMethods");
        public static Cost_Drivers swetools = new Cost_Drivers(1.24,1.10,1.00,0.91,0.83,0.00, "swetools");
        public static Cost_Drivers developmentSchedule = new Cost_Drivers(1.23,1.08,1.00,1.04,1.10,0.00, "developmentSchedule");
        /// <summary>     
        /// /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
