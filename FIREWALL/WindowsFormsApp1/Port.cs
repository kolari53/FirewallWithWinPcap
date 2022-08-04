using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using PcapDotNet.Analysis;
using PcapDotNet.Core;
using PcapDotNet.Packets;
using PcapDotNet.Base;
using PcapDotNet.Packets.IpV4;
using PcapDotNet.Packets.Transport;
using PcapDotNet.Packets.Http;
using NetFwTypeLib;

namespace WindowsFormsApp1
{
    public partial class Port : Form
    {
        private IList<LivePacketDevice> AdaptersList;
        private PacketDevice selectedAdapter;
        private bool first_time = true; //boolern değişken gerekli on re-capturing
        public static byte[] payload;
        public static Dictionary<int, Packet1> packets = new Dictionary<int, Packet1>();



        public Port()
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
            PcapDotNetAnalysis.OptIn = true;//kullanılam pcap analizi

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!sayac.Equals(""))
            {
                ListViewItem item = new ListViewItem(zaman);
                item.SubItems.Add(kaynak);
                item.SubItems.Add(hedef);
                item.SubItems.Add(protokol);
                ListViewItem item1 = new ListViewItem(kaynak);
                item1.SubItems.Add(tcpsrc);
                item1.SubItems.Add(tcpdes);
                item1.SubItems.Add(protokol);
                ListViewItem item2 = new ListViewItem(tcpsrc);




                if (protokol.Equals("Tcp"))
                {
                    textBox1.Text = "Protokol :  Tcp  \r\n SourcePort :  " + tcpsrc + "\r\n DestinationPort :  " + tcpdes + "\r\n SequenceNumber :  " + tcpsec + "\r\n NextSequenceNuber :  " + tcpnsec + "\r\n AcknowladgmentNumber :  " + tcpack;
                    if (save.Checked)
                    {
                        using (StreamWriter writer = new StreamWriter(@"C:\Users\ehdey\Desktop\BİTİRME\deneme\tcp.txt", true))
                        {
                            writer.Write("Protocol :  Tcp  \r\n SourcePort :  " + tcpsrc + "\r\n DestinationPort :  " + tcpdes + "\r\n SequenceNumber :  " + tcpsec + "\r\n NextSequenceNuber :  " + tcpnsec + "\r\n AcknowladgmentNumber :  " + tcpack + "\r\n --------------------------------------------- \r\n");
                        }
                    }
                }
                else
                {
                    if (protokol.Equals("Http"))
                    {
                        textBox1.Text = "Protokol :  Http  \r\n Version :  " + httpver + "\r\n Length :  " + httplen + "\r\n Type :  " + reqres + "\r\n Header :  \r\n" + httpheader + "\r\n Body :  \r\n" + httpbody;
                        if (save.Checked)
                        {
                            using (StreamWriter writer = new StreamWriter(@"C:\Users\ehdey\Desktop\BİTİRME\deneme\http.txt", true))
                            {
                                writer.Write("Protocol :  Http  \r\n Version :  " + httpver + "\r\n Length :  " + httplen + "\r\n Type :  " + reqres + "\r\n Header :  \r\n" + httpheader + "\r\n --------------------------------------------- \r\n");
                            }
                        }
                    }
                    else
                    {
                        if (protokol.Equals("Udp"))
                        {

                            textBox1.Text = "Protocol :  Udp  \r\n SourcePort :  " + udpscr + "\r\n DestinationPort :  " + udpdes;
                            if (save.Checked)
                            {
                                using (StreamWriter writer = new StreamWriter(@"C:\Users\ehdey\Desktop\BİTİRME\deneme\udp.txt", true))
                                {
                                    writer.Write("Protocol :  Udp  \r\n SourcePort :  " + udpscr + "\r\n DestinationPort :  " + udpdes + "\r\n --------------------------------------------- \r\n");
                                }
                            }
                        }
                    }
                }
                if (protokol.Equals("Tcp"))
                {
                    listView2.Items.Insert(0, item1);
                    listView3.Items.Insert(0, item2);
                    if (listBox1.Items.Contains(item2.Text) == false)
                    {
                        listBox1.Items.Add(item2.Text);

                    }
                    else
                    {

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
        string sayac = " ";
        string zaman = " ";
        string kaynak = " ";
        string hedef = " ";
        string protokol = " ";
        string uzunluk = " ";
        string tcpack = "";
        string tcpsec = "";
        string tcpnsec = "";
        string tcpsrc = "";
        string tcpdes = "";
        string udpscr = "";
        string udpdes = "";
        string httpheader = "";
        string httpbody = "";
        string httpver = "";
        string httplen = "";
        string reqres = "";
        //Kayıt için gerekli değişkenler
        string dosyaismi = "";
        string yol = "";

        private void PacketHandler(Packet packet)
        {

            this.sayac = ""; this.zaman = ""; this.kaynak = ""; this.hedef = ""; this.protokol = ""; this.uzunluk = "";

            this.tcpack = ""; this.tcpsec = ""; this.tcpnsec = ""; this.tcpsrc = ""; this.tcpdes = ""; this.udpscr = "";

            this.udpdes = ""; this.httpheader = ""; this.httpver = ""; this.httplen = ""; this.reqres = ""; this.httpbody = "";

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
                    httpheader = httpPacket.Header.ToString();
                    sayac = packet.Count.ToString();
                    zaman = packet.Timestamp.ToString();
                    this.kaynak = ip.Source.ToString();
                    this.hedef = ip.Destination.ToString();
                    uzunluk = ip.Length.ToString();
                    httpver = httpPacket.Version.ToString();
                    httplen = httpPacket.Length.ToString();
                    httpbody = httpPacket.Body.ToString();

                    if (httpPacket.IsRequest)
                    {
                        reqres = "Request";
                    }
                    else
                    {
                        reqres = "Response";
                    }
                }
                else
                {

                    sayac = packet.Count.ToString();
                    zaman = packet.Timestamp.ToString();
                    this.kaynak = ip.Source.ToString();
                    this.hedef = ip.Destination.ToString();
                    uzunluk = ip.Length.ToString();
                    protokol = ip.Protocol.ToString();

                    tcpsrc = tcp.SourcePort.ToString();
                    tcpdes = tcp.DestinationPort.ToString();
                    tcpack = tcp.AcknowledgmentNumber.ToString();
                    tcpsec = tcp.SequenceNumber.ToString();
                    tcpnsec = tcp.NextSequenceNumber.ToString();
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
                    udpscr = udp.SourcePort.ToString();
                    udpdes = udp.DestinationPort.ToString();
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

            if (ip.Protocol.ToString().Equals("Tcp") && (save.Checked))
            {
                int _source = tcp.SourcePort;
                int _destination = tcp.DestinationPort;

                if (tcp.PayloadLength != 0) //not syn or ack
                {
                    payload = new byte[tcp.PayloadLength];
                    tcp.Payload.ToMemoryStream().Read(payload, 0, tcp.PayloadLength);// Veriyi oku
                    if (_destination == 80)// request from server
                    {
                        Packet1 packet1 = new Packet1();
                        int i = Array.IndexOf(payload, (byte)32, 6);
                        byte[] t = new byte[i - 5];
                        Array.Copy(payload, 5, t, 0, i - 5);
                        packet1.Name = System.Text.ASCIIEncoding.ASCII.GetString(t);

                        if (!packets.ContainsKey(_source))
                            packets.Add(_source, packet1);
                    }
                    else
                        if (_source == 80)
                        if (packets.ContainsKey(_destination))
                        {
                            Packet1 packet1 = packets[_destination];
                            if (packet1.Data == null)
                            {
                                if ((httpPacket.Header != null) && (httpPacket.Header.ContentLength != null))
                                {
                                    packet1.Data = new byte[(uint)httpPacket.Header.ContentLength.ContentLength];
                                    Array.Copy(httpPacket.Body.ToMemoryStream().ToArray(), packet1.Data, httpPacket.Body.Length);
                                    packet1.Order = (uint)(tcp.SequenceNumber + payload.Length - httpPacket.Body.Length);
                                    packet1.Data_Length = httpPacket.Body.Length;
                                    for (int i = 0; i < packet1.TempPackets.Count; i++)
                                    {
                                        Temp tempPacket = packet1.TempPackets[i];
                                        Array.Copy(tempPacket.data, 0, packet1.Data, tempPacket.tempSeqNo - packet1.Order, tempPacket.data.Length);
                                        packet1.Data_Length += tempPacket.data.Length;
                                    }
                                }
                                else
                                {
                                    Temp tempPacket = new Temp();
                                    tempPacket.tempSeqNo = (uint)tcp.SequenceNumber;
                                    tempPacket.data = new byte[payload.Length];
                                    Array.Copy(payload, tempPacket.data, payload.Length);
                                    packet1.TempPackets.Add(tempPacket);
                                }
                            }
                            else if (packet1.Data_Length != packet1.Data.Length)
                            {
                                Array.Copy(payload, 0, packet1.Data, tcp.SequenceNumber - packet1.Order, payload.Length);

                                packet1.Data_Length += payload.Length;
                            }

                            if (packet1.Data != null)
                                if (packet1.Data_Length == packet1.Data.Length)
                                {

                                    using (BinaryWriter writer = new BinaryWriter(File.Open(@"E:\ali\" + Directory.CreateDirectory(Path.GetFileName(packet1.Name)), FileMode.Create)))
                                    {
                                        writer.Write(packet1.Data);

                                    }

                                    packets.Remove(_destination);

                                }
                        }
                }
            }

        }

        private void Port_Load(object sender, EventArgs e)
        {
            listView1.Visible = false;
            listView3.Visible = false;

        }

        

        private void button2_Click(object sender, EventArgs e)
        {

            int[] port = new int[listBox1.Items.Count];


            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                port[i] = Convert.ToInt32(listBox1.Items[i]);
            }

            bloklaport(port);
            MessageBox.Show("Portlar Engellenmiştir !!");

        }
        private void bloklaport(int[] port)
        {
            int a = port.Length;

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
                    inboundRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
                    inboundRule.Protocol = 6;
                    inboundRule.LocalPorts = port[i].ToString();
                    inboundRule.Name = port[i].ToString(); // Kural ismi
                    inboundRule.Profiles = currentProfiles;
                    inboundRule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;


                    INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
                    firewallPolicy.Rules.Add(inboundRule);
                }

            }

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

        private void IpEngelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Length formsec = new Length();
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

        private void AğToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AnaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ana formsec = new Ana();
            formsec.Show();
            this.Hide();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Type tNetFwPolicy2 = Type.GetTypeFromProgID("HNetCfg.FwPolicy2");
            INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(tNetFwPolicy2);
            var currentProfiles = fwPolicy2.CurrentProfileTypes;
            INetFwRule firewallRule = fwPolicy2.Rules.OfType<INetFwRule>().Where(x => x.Name == "TCP").FirstOrDefault(); //
            if (firewallRule == null)
            {
                INetFwRule2 inboundRule = (INetFwRule2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
                inboundRule.Enabled = true;
                inboundRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
                inboundRule.Protocol = 6;
                inboundRule.RemotePorts = textBox2.Text.ToString();
                inboundRule.Name =textBox2.Text.ToString(); // Kural ismi
                inboundRule.Profiles = currentProfiles;
                inboundRule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;


                INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
                firewallPolicy.Rules.Add(inboundRule);
                
            }
            string a = textBox2.Text.ToString();
            System.IO.File.WriteAllText(@"C:\Users\ehdey\Desktop\BİTİRME\deneme\port.txt", a);
            textBox2.Clear();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
                INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
                firewallPolicy.Rules.Remove(textBox2.Text.ToString());
            
            textBox2.Clear();
        }
    }
}