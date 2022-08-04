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


namespace WindowsFormsApp1
{
    public partial class Dinle : Form
    {
        private IList<LivePacketDevice> AdaptersList;
        private PacketDevice selectedAdapter;
        private bool first_time = true; 


        public Dinle()
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!sayac.Equals(""))
            {
                ListViewItem item = new ListViewItem(zaman);
                item.SubItems.Add(kaynak);
                item.SubItems.Add(hedef);
                item.SubItems.Add(protokol);
                if (protokol.Equals("Tcp"))
                {
                    
                    if (save.Checked)
                    {
                        using (StreamWriter writer = new StreamWriter(@"C:\Users\geyge\Desktop\BİTİRME\deneme\tcp.txt", true))
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
                            using (StreamWriter writer = new StreamWriter(@"C:\Users\geyge\Desktop\BİTİRME\deneme\http.txt", true))
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
                                using (StreamWriter writer = new StreamWriter(@"C:\Users\geyge\Desktop\BİTİRME\deneme\udp.txt", true))
                                {
                                    writer.Write("Zaman:   \r\n: " + zaman + "\r\n protokol: " + protokol + "\r\n hedef: " + hedef + "\r\n kaynak:  \r\n" + kaynak + "\r\n uzunluk :" + uzunluk + "\r\n-------------------------------------------- - \r\n");
                                }
                            }
                        }
                    }
                }

                item.SubItems.Add(uzunluk);
                listView1.Items.Insert(0, item);

            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
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

        private void AnaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ana formsec = new Ana();
            formsec.Show();
            this.Hide();
        }
    }
}
