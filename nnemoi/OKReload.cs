﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nnemoi
{
    public partial class OKReload : Form
    {
        private void DoOperation(string oparation)
        {
            string filename = string.Empty;
            string arguments = string.Empty;

            switch (oparation)
            {
                case "Перезагрузка":
                    filename = "shutdown.exe";
                    arguments = "-r";
                    break;
            }

            ProcessStartInfo processStartInfo = new ProcessStartInfo(filename, arguments);
            Process.Start(processStartInfo);

            this.Close();
        }

        public OKReload()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Restart = "Перезагрузка";
            DoOperation(Restart);
            this.Close();
        }
    }
}
