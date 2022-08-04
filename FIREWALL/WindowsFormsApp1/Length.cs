using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PcapDotNet.Analysis;
using PcapDotNet.Core;
using PcapDotNet.Packets;
using PcapDotNet.Base;
using PcapDotNet.Packets.IpV4;
using PcapDotNet.Packets.Transport;
using PcapDotNet.Packets.Http;
using System.IO;
using NetFwTypeLib;

namespace WindowsFormsApp1
{
    public partial class Length : Form
    {
        private IList<LivePacketDevice> AdaptersList;
        private PacketDevice selectedAdapter;
        private bool first_time = true;
        public Length()
        {
            InitializeComponent();
            try
            {
                AdaptersList = LivePacketDevice.AllLocalMachine;//bütün adaptörleri göster
            }
            catch (Exception e)
            {
                MessageBox.Show("Adaptörler Listelenemedi");
            }
            PcapDotNetAnalysis.OptIn = true;

            if (AdaptersList.Count == 0)
            {

                MessageBox.Show("Adaptör bulunamadı !!");

                return;

            }
            for (int i = 0; i != AdaptersList.Count; ++i)//Tüm adaptörleri combobox'a ekle...
            {
                LivePacketDevice Adapter = AdaptersList[i];

                if (Adapter.Description != null)

                    adapters_list.Items.Add(Adapter.Description);
                else
                    adapters_list.Items.Add("İsimsiz");
            }
        }

        private void Length_Load(object sender, EventArgs e)
        {
            listView2.Visible = false;


            listView4.Visible = false;
            tcp.Visible = false;
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            if (!first_time)//Programı resetlemek için
            {
                Application.Restart();
            }
            else if (adapters_list.SelectedIndex >= 0)//Adaptör seçiliyse
            {
                timer1.Enabled = true;//paketleri listview'e ekle
                selectedAdapter = AdaptersList[adapters_list.SelectedIndex];//comboboxdaki seçili adaptörü al
                backgroundWorker1.RunWorkerAsync();//Filtreye göre yakalamayı başlat
                start_button.Enabled = false;
                stop_button.Enabled = true;
                adapters_list.Enabled = false;
                _tcp.Enabled = false;
                _udp.Enabled = false;
                first_time = false;
                save.Enabled = false;
            }
            else
            {
                MessageBox.Show("Bir adaptör seçiniz !");
            }
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            start_button.Enabled = true;
            stop_button.Enabled = false;
            adapters_list.Enabled = true;
            _tcp.Enabled = true;
            _udp.Enabled = true;
            timer1.Enabled = false;
            start_button.Text = "Yeniden Başlat";
            save.Enabled = true;
        }
        //Paket bilgileri için gerekli değişkenler
        string sayac = " ";
        string zaman = " ";
        string kaynak = " ";
        string hedef = " ";
        string protokol = " ";
        string uzunluk = " ";

        private void PacketHandler(Packet packet)
        {

            this.sayac = ""; this.zaman = ""; this.kaynak = ""; this.hedef = ""; this.protokol = ""; this.uzunluk = "";


            IpV4Datagram ip = packet.Ethernet.IpV4;
            TcpDatagram tcp = ip.Tcp;
            UdpDatagram udp = ip.Udp;
            HttpDatagram httpPacket = null;

            if (ip.Protocol.ToString().Equals("Tcp"))
            {
                httpPacket = tcp.Http;//Tcp ise başlat

                if ((httpPacket.Header != null) && (!_tcp.Checked))
                {
                    protokol = "Http";

                    sayac = packet.Count.ToString();
                    zaman = packet.Timestamp.ToString();
                    this.kaynak = ip.Source.ToString();
                    this.hedef = ip.Destination.ToString();
                    uzunluk = ip.Length.ToString();


                }
                else
                {

                    sayac = packet.Count.ToString();
                    zaman = packet.Timestamp.ToString();
                    this.kaynak = ip.Source.ToString();
                    this.hedef = ip.Destination.ToString();
                    uzunluk = ip.Length.ToString();
                    protokol = ip.Protocol.ToString();


                }
            }
            else
            {
                if ((ip.Protocol.ToString().Equals("Udp")))
                {
                    sayac = packet.Count.ToString();
                    zaman = packet.Timestamp.ToString();
                    this.kaynak = ip.Source.ToString();
                    this.hedef = ip.Destination.ToString();
                    uzunluk = ip.Length.ToString();
                    protokol = ip.Protocol.ToString();

                }
                else
                {

                    sayac = packet.Count.ToString();
                    zaman = packet.Timestamp.ToString();
                    this.kaynak = ip.Source.ToString();
                    this.hedef = ip.Destination.ToString();
                    uzunluk = ip.Length.ToString();
                    protokol = ip.Protocol.ToString();

                }

            }



        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (!sayac.Equals(""))
            {
                ListViewItem item = new ListViewItem(zaman);
                item.SubItems.Add(kaynak);
                item.SubItems.Add(hedef);
                item.SubItems.Add(protokol);
                ListViewItem item1 = new ListViewItem(kaynak);
                ListViewItem item2 = new ListViewItem(kaynak);
                if (protokol.Equals("Tcp"))
                {

                    if (save.Checked)
                    {
                        using (StreamWriter writer = new StreamWriter(@"E:\deneme\tcp.txt", true))
                        {
                            writer.Write("Zaman:   \r\n: " + zaman + "\r\n protokol: " + protokol + "\r\n hedef: " + hedef + "\r\n kaynak:  \r\n" + kaynak + "\r\n uzunluk : " + uzunluk + "\r\n-------------------------------------------- - \r\n");
                        }
                    }
                }
                else
                {
                    if (protokol.Equals("Http"))
                    {

                        if (save.Checked)
                        {
                            using (StreamWriter writer = new StreamWriter(@"E:\deneme\http.txt", true))
                            {
                                writer.Write("Zaman:  :  " + zaman + "\r\n protokol :  " + protokol + "\r\n hedef:  " + hedef + "\r\n kaynak : " + kaynak + "\r\n uzunluk :  " + uzunluk + "\r\n --------------------------------------------- \r\n");
                            }
                        }
                    }
                    else
                    {
                        if (protokol.Equals("Udp"))
                        {


                            if (save.Checked)
                            {
                                using (StreamWriter writer = new StreamWriter(@"E:\deneme\udp.txt", true))
                                {
                                    writer.Write("Zaman:   \r\n: " + zaman + "\r\n protokol: " + protokol + "\r\n hedef: " + hedef + "\r\n kaynak:  \r\n" + kaynak + "\r\n uzunluk :" + uzunluk + "\r\n-------------------------------------------- - \r\n");
                                }
                            }
                        }
                    }
                }

                item.SubItems.Add(uzunluk);
                listView1.Items.Insert(0, item);

                if (protokol.Equals("Udp"))
                {
                    int b = Convert.ToInt32(textBox1.Text);
                    udp.Text = uzunluk;
                    int uzunn = Convert.ToInt32(udp.Text);
                    if (20 < uzunn && uzunn < b)
                    {

                    }
                    else
                    {
                        if (kaynak != "192.168.1.42")
                        {
                            listView4.Items.Insert(0, item2);
                            if (listBox2.Items.Contains(item2.Text) == false)
                            {
                                listBox2.Items.Add(item2.Text);

                            }
                            else
                            {

                            }
                        }
                    }

                }
                if (protokol.Equals("Tcp"))
                {
                    int a = Convert.ToInt32(textBox1.Text);

                    tcp.Text = uzunluk;
                    int uzun = Convert.ToInt32(tcp.Text);
                    if (20 < uzun && uzun < a)
                    {

                    }
                    else
                    {

                        if (kaynak != "192.168.1.42")
                        {
                            listView2.Items.Insert(0, item1);

                            if (listBox1.Items.Contains(item1.Text) == false)
                            {
                                listBox1.Items.Add(item1.Text);

                            }
                            else
                            {

                            }
                        }


                    }

                }

            }
        }

        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
            using (PacketCommunicator communicator = selectedAdapter.Open(65536, PacketDeviceOpenAttributes.Promiscuous, 1000))
            {
                // Link katmanının kontrol et.
                if (communicator.DataLink.Kind != DataLinkKind.Ethernet)
                {
                    MessageBox.Show("Ethernet kartının adaptörünü seçiniz");

                    return;
                }




                if (_tcp.Checked && (!_udp.Checked))//Sadece tcp
                {
                    using (BerkeleyPacketFilter filter = communicator.CreateFilter("tcp"))
                    {
                        // Filtreyi ayarla
                        communicator.SetFilter(filter);
                    }
                }
                else if (_udp.Checked && !(_tcp.Checked))//sadece udp
                {
                    using (BerkeleyPacketFilter filter = communicator.CreateFilter("udp"))
                    {
                        // Filtreyi ayarla
                        communicator.SetFilter(filter);
                    }
                }
                else if (_tcp.Checked && (_udp.Checked))//tcp ve udp
                {
                    using (BerkeleyPacketFilter filter = communicator.CreateFilter("ip and udp"))
                    {
                        // Filtreyi ayarla
                        communicator.SetFilter(filter);
                    }
                }

                // Yakalamaya başla
                communicator.ReceivePackets(0, PacketHandler);
            }
        }

      
        private void bloklomatcp(string[] ip)
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
                inboundRule.Action = NET_FW_ACTION_.NET_FW_ACTION_ALLOW;
                inboundRule.Protocol = 6; // TCP Protokol Numarası
                    inboundRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
                inboundRule.Name = "EKHO"; // Kural ismi
                inboundRule.Profiles = currentProfiles;


                inboundRule.RemoteAddresses = ip[i];


                inboundRule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;


                INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
                firewallPolicy.Rules.Add(inboundRule);
            }
        }

        }
        private void bloklamaudp(string[] ip)
        {
            int a = ip.Length;

            for (int i = 0; i < a; i++)
            {
                Type tNetFwPolicy2 = Type.GetTypeFromProgID("HNetCfg.FwPolicy2");
                INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(tNetFwPolicy2);
                var currentProfiles = fwPolicy2.CurrentProfileTypes;
                INetFwRule firewallRule = fwPolicy2.Rules.OfType<INetFwRule>().Where(x => x.Name == "UDP").FirstOrDefault(); //
                if (firewallRule == null)
                {
                    INetFwRule2 inboundRule = (INetFwRule2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
                    inboundRule.Enabled = true;
                    inboundRule.Action = NET_FW_ACTION_.NET_FW_ACTION_ALLOW;
                    inboundRule.Protocol = 17; // UDP Protokol Numarası
                    inboundRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
                    inboundRule.Name = "EKHO"; // Kural ismi
                    inboundRule.Profiles = currentProfiles;


                    inboundRule.RemoteAddresses = ip[i];


                    inboundRule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;


                    INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
                    firewallPolicy.Rules.Add(inboundRule);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string[] IP = new string[listBox1.Items.Count];


            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                IP[i] = listBox1.Items[i].ToString();
            }
            bloklomatcp(IP);
            MessageBox.Show("Listelenen IP'ler Engellenmiştir!!");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] IP = new string[listBox2.Items.Count];


            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                IP[i] = listBox2.Items[i].ToString();
            }
            bloklamaudp(IP);
            MessageBox.Show("Listelenen IP'ler Engellenmiştir!!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] ip = new string[listBox1.Items.Count];
            listBox1.Items.CopyTo(ip, 0);
            System.IO.File.WriteAllLines(@"C:\Users\geyge\Desktop\BİTİRME\deneme\engelliip.txt", ip);
            MessageBox.Show("Listelenen IP'ler Kaydedilmiştir!!");
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
