using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Ana : Form
    {
        public Ana()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dinle formsec = new Dinle();
            formsec.Show();
            this.Hide();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            izin formsec = new izin();
            formsec.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ac formsec = new Ac();
            formsec.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void ÇıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ÇıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AğDinlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ağa gelen paketleri istenilen kriterlere göre listeler");
        }

        private void ErişimeİzinVerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Engellenmiş olan ipnin erişimine izin verir");

        }

        private void DataLengthToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Paket büyüklüğüne göre verilen kriterleri aşan peketleri engeller");
        }

        private void PortToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Listelenen portlar üzerinden port engeller");
        }

        private void IPGrişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Verilen ip adresini engeller");
        }

        private void EngelKaldırmaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Engellenen iplerin erişimine izin verir");
        }

        private void WindowsDefenderFireWollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Administrative Tools\Windows Defender Firewall with Advanced Security");
        }
    }
}
 