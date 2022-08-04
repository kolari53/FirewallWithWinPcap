using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetFwTypeLib;

namespace WindowsFormsApp1
{
    public partial class izin : Form
    {
        public izin()
        {
            InitializeComponent();
        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
        }
        private void izinip(string[] ip)
        {
            int a = ip.Length;

            for (int i = 0; i < a; i++)
            {
                Type tNetFwPolicy2 = Type.GetTypeFromProgID("HNetCfg.FwPolicy2");
                INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(tNetFwPolicy2);
                var currentProfiles = fwPolicy2.CurrentProfileTypes;
                INetFwRule firewallRule = fwPolicy2.Rules.OfType<INetFwRule>().Where(x => x.Name == "TCP").FirstOrDefault(); //
                if (firewallRule == null)
                {
                    INetFwRule2 inboundRule = (INetFwRule2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
                    inboundRule.Enabled = true;
               

                    inboundRule.Name = "EKHO"; // Kural ismi
                    inboundRule.Profiles = currentProfiles;


                    inboundRule.RemoteAddresses = ip[i];

                   inboundRule.Action = NET_FW_ACTION_.NET_FW_ACTION_ALLOW;
                  


                    INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
                    firewallPolicy.Rules.Add(inboundRule);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string[] IP = new string[listBox1.Items.Count];


            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                IP[i] = listBox1.Items[i].ToString();
            }
            izinip(IP);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ana formsec = new Ana();
            formsec.Show();
            this.Hide();
        }

        private void AğıDinleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dinle formsec = new Dinle();
            formsec.Show();
            this.Hide();
        }

        private void ErişimeİzinVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            izin formsec = new izin();
            formsec.Show();
            this.Hide();
        }

        private void DataLengthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Length formsec = new Length();
            formsec.Show();
            this.Hide();
        }

        private void PortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Port formsec = new Port();
            formsec.Show();
            this.Hide();
        }

        private void IpGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ipal formsec = new Ipal();
            formsec.Show();
            this.Hide();
        }

        private void EngelKaldırmaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ac formsec = new Ac();
            formsec.Show();
            this.Hide();
        }

        private void ÇıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AnasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ana formsec = new Ana();
            formsec.Show();
            this.Hide();
        }
    }
}
