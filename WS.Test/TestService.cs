using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WS.Test
{
    public partial class TestService : ServiceBase
    {
        public TestService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            var log = $"{DateTime.Now:DD-MM-YYYYThh:mm:sss}";
            if (!(log is string stringLog)) return;
            using (var sw = File.CreateText("D:\\log.txt"))
            {
                sw.Write(stringLog);
            }
        }

        protected override void OnStop()
        {
        }
    }
}
