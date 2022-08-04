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
    public partial class Ac : Form
    {
        public Ac()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] ip = System.IO.File.ReadAllLines(@"C:\Users\ehdey\Desktop\BİTİRME\deneme\engelliip.txt", System.Text.Encoding.Default);
            foreach (string str in ip)
            {
                comboBox1.Items.Add(str);
            }
      

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem != null)
            {
                listBox1.Items.Add(comboBox1.SelectedItem);
            }
        }
        private void izinip(string[] ip)
        {
            int a = ip.Length;

            for (int i = 0; i < a; i++)
            {
                      INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
                     firewallPolicy.Rules.Remove(ip[i].ToString());
                
            }
        }
    
        private void button2_Click(object sender, EventArgs e)
        {
            string[] IP = new string[listBox1.Items.Count];


            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                IP[i] = listBox1.Items[i].ToString();
            }
            izinip(IP);
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void AnaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ana formsec = new Ana();
            formsec.Show();
            this.Hide();
        }
    }
}
