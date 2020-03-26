using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MyTcpView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }





        private void button1_Click(object sender, EventArgs e)
        {

            // ConnectionManager.CloseConnByLocalPort(2345);
            var ps = NetProcessAPI.GetAllTcpConnections();
            foreach (var p in ps)
            {
                dataGridView1.Rows.Add(new object[] { ProcessAPI.GetIcon(p.owningPid, true), ProcessAPI.GetProcessNameByPID(p.owningPid), p.owningPid.ToString(), "TCP", p.LocalAddress.ToString(), p.LocalPort.ToString(), p.RemoteAddress.ToString(), p.RemotePort.ToString() });
            }
            foreach (var p in NetProcessAPI.GetAllUdpConnections())
            {
                dataGridView1.Rows.Add(new object[] { ProcessAPI.GetIcon(p.owningPid, true), ProcessAPI.GetProcessNameByPID(p.owningPid), p.owningPid.ToString(), "UDP", p.LocalAddress.ToString(), p.LocalPort.ToString(), "", "" });
            }
        }
    }
}
