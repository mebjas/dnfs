using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace dnfsd
{
    public partial class dnfs_daemon : ServiceBase
    {
        public dnfs_daemon()
        {
            InitializeComponent();
        }

        #if DEBUG
        public void onDebug() {
            OnStart(null);
        }
        #endif

        protected override void OnStart(string[] args)
        {
            File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +@"\dnfsd.ini", DateTime.Now.ToString());
        }

        protected override void OnStop()
        {
            File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\dnfsdc.ini", DateTime.Now.ToString());
        }
    }
}
