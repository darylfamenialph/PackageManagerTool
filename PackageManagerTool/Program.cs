using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversalDatabaseAdapter;
using UniversalDatabaseAdapter.Adapters;

namespace PackageManagerTool
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new VwDashboard());

           var facility = "UK";
           // var facility = "LTI";
          var _databaseSettings = new DatabaseSettings(new MySqlAdapter(host: "", password: "", username: ""));
            var appController = new ApplicationController(_databaseSettings, facility,2058,"kfamenial","Admin");
            appController.RunSystem();
        }
    }
}
