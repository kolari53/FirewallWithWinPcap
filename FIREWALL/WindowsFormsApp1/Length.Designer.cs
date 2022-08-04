namespace WindowsFormsApp1
{
    partial class Length
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Length));
            this.listView4 = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.udp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tcp = new System.Windows.Forms.Label();
            this.stop_button = new System.Windows.Forms.Button();
            this._udp = new System.Windows.Forms.CheckBox();
            this._tcp = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adapters_label = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.start_button = new System.Windows.Forms.Button();
            this.adapters_list = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.save = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ağToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ağıDinleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ıPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erişimeİzinVerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ıpEngelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataLengthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ıpGirişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.engelKaldırmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.engelKaldırmaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anasayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView4
            // 
            this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8});
            this.listView4.FullRowSelect = true;
            this.listView4.GridLines = true;
            this.listView4.Location = new System.Drawing.Point(770, 373);
            this.listView4.Margin = new System.Windows.Forms.Padding(4);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(136, 183);
            this.listView4.TabIndex = 63;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Bloklanacak IP\'ler UDP";
            this.columnHeader8.Width = 182;
            // 
            // udp
            // 
            this.udp.AutoSize = true;
            this.udp.Location = new System.Drawing.Point(803, 348);
            this.udp.Name = "udp";
            this.udp.Size = new System.Drawing.Size(35, 13);
            this.udp.TabIndex = 62;
            this.udp.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "UDP";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(350, 385);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(228, 147);
            this.listBox2.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "TCP";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(202, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 58;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(54, 398);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(228, 147);
            this.listBox1.TabIndex = 57;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(618, 373);
            this.listView2.Margin = new System.Windows.Forms.Padding(4);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(136, 183);
            this.listView2.TabIndex = 56;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Bloklanacak IP\'ler TCP";
            this.columnHeader7.Width = 182;
            // 
            // tcp
            // 
            this.tcp.AutoSize = true;
            this.tcp.Location = new System.Drawing.Point(860, 348);
            this.tcp.Name = "tcp";
            this.tcp.Size = new System.Drawing.Size(35, 13);
            this.tcp.TabIndex = 55;
            this.tcp.Text = "label1";
            // 
            // stop_button
            // 
            this.stop_button.BackColor = System.Drawing.Color.Transparent;
            this.stop_button.Enabled = false;
            this.stop_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.stop_button.ForeColor = System.Drawing.Color.Black;
            this.stop_button.Location = new System.Drawing.Point(597, 125);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(190, 32);
            this.stop_button.TabIndex = 54;
            this.stop_button.Text = "Durdur";
            this.stop_button.UseVisualStyleBackColor = false;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // _udp
            // 
            this._udp.AutoSize = true;
            this._udp.BackColor = System.Drawing.Color.Transparent;
            this._udp.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this._udp.ForeColor = System.Drawing.Color.White;
            this._udp.Location = new System.Drawing.Point(264, 60);
            this._udp.Name = "_udp";
            this._udp.Size = new System.Drawing.Size(52, 20);
            this._udp.TabIndex = 52;
            this._udp.Text = "UDP";
            this._udp.UseVisualStyleBackColor = false;
            // 
            // _tcp
            // 
            this._tcp.AutoSize = true;
            this._tcp.BackColor = System.Drawing.Color.Transparent;
            this._tcp.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this._tcp.ForeColor = System.Drawing.Color.White;
            this._tcp.Location = new System.Drawing.Point(208, 58);
            this._tcp.Name = "_tcp";
            this._tcp.Size = new System.Drawing.Size(50, 20);
            this._tcp.TabIndex = 51;
            this._tcp.Text = "TCP";
            this._tcp.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(63, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 19);
            this.label3.TabIndex = 50;
            this.label3.Text = "Filtreyi Seçiniz :";
            // 
            // adapters_label
            // 
            this.adapters_label.AutoSize = true;
            this.adapters_label.BackColor = System.Drawing.Color.Transparent;
            this.adapters_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.adapters_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.adapters_label.Location = new System.Drawing.Point(63, 36);
            this.adapters_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adapters_label.Name = "adapters_label";
            this.adapters_label.Size = new System.Drawing.Size(239, 19);
            this.adapters_label.TabIndex = 49;
            this.adapters_label.Text = "Network Adaptörünü Seçin :";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(54, 175);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(733, 177);
            this.listView1.TabIndex = 48;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Zaman";
            this.columnHeader2.Width = 142;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kaynak";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 142;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Hedef";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 142;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Protokol";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Uzunluk";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 115;
            // 
            // start_button
            // 
            this.start_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.start_button.ForeColor = System.Drawing.Color.Black;
            this.start_button.Location = new System.Drawing.Point(383, 125);
            this.start_button.Margin = new System.Windows.Forms.Padding(4);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(176, 32);
            this.start_button.TabIndex = 47;
            this.start_button.Text = "Başlat";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // adapters_list
            // 
            this.adapters_list.FormattingEnabled = true;
            this.adapters_list.Location = new System.Drawing.Point(337, 30);
            this.adapters_list.Margin = new System.Windows.Forms.Padding(4);
            this.adapters_list.Name = "adapters_list";
            this.adapters_list.Size = new System.Drawing.Size(341, 21);
            this.adapters_list.TabIndex = 46;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork_1);
            // 
            // save
            // 
            this.save.AutoSize = true;
            this.save.BackColor = System.Drawing.Color.Transparent;
            this.save.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(685, 30);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(79, 22);
            this.save.TabIndex = 53;
            this.save.Text = "Kaydet";
            this.save.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 133);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 65;
            this.label1.Text = "Paket Boyutu Girin";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(831, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 36);
            this.button2.TabIndex = 66;
            this.button2.Text = "Engelle TCP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(831, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 26);
            this.button3.TabIndex = 67;
            this.button3.Text = "Engelle UDP";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(815, 252);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 29);
            this.button4.TabIndex = 68;
            this.button4.Text = "Dosyaya Kaydet";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anasayfaToolStripMenuItem,
            this.ağToolStripMenuItem,
            this.ıPToolStripMenuItem,
            this.engelKaldırmaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1012, 24);
            this.menuStrip1.TabIndex = 69;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ağToolStripMenuItem
            // 
            this.ağToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ağıDinleToolStripMenuItem});
            this.ağToolStripMenuItem.Name = "ağToolStripMenuItem";
            this.ağToolStripMenuItem.Size = new System.Drawing.Size(34, 20);
            this.ağToolStripMenuItem.Text = "Ağ";
            // 
            // ağıDinleToolStripMenuItem
            // 
            this.ağıDinleToolStripMenuItem.Name = "ağıDinleToolStripMenuItem";
            this.ağıDinleToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.ağıDinleToolStripMenuItem.Text = "Ağı Dinle";
            this.ağıDinleToolStripMenuItem.Click += new System.EventHandler(this.AğıDinleToolStripMenuItem_Click);
            // 
            // ıPToolStripMenuItem
            // 
            this.ıPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.erişimeİzinVerToolStripMenuItem,
            this.ıpEngelleToolStripMenuItem});
            this.ıPToolStripMenuItem.Name = "ıPToolStripMenuItem";
            this.ıPToolStripMenuItem.Size = new System.Drawing.Size(29, 20);
            this.ıPToolStripMenuItem.Text = "IP";
            // 
            // erişimeİzinVerToolStripMenuItem
            // 
            this.erişimeİzinVerToolStripMenuItem.Name = "erişimeİzinVerToolStripMenuItem";
            this.erişimeİzinVerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.erişimeİzinVerToolStripMenuItem.Text = "Erişime İzin Ver";
            this.erişimeİzinVerToolStripMenuItem.Click += new System.EventHandler(this.ErişimeİzinVerToolStripMenuItem_Click);
            // 
            // ıpEngelleToolStripMenuItem
            // 
            this.ıpEngelleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataLengthToolStripMenuItem,
            this.portToolStripMenuItem,
            this.ıpGirişToolStripMenuItem});
            this.ıpEngelleToolStripMenuItem.Name = "ıpEngelleToolStripMenuItem";
            this.ıpEngelleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ıpEngelleToolStripMenuItem.Text = "Ip Engelle";
            // 
            // dataLengthToolStripMenuItem
            // 
            this.dataLengthToolStripMenuItem.Name = "dataLengthToolStripMenuItem";
            this.dataLengthToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.dataLengthToolStripMenuItem.Text = "data length";
            this.dataLengthToolStripMenuItem.Click += new System.EventHandler(this.DataLengthToolStripMenuItem_Click);
            // 
            // portToolStripMenuItem
            // 
            this.portToolStripMenuItem.Name = "portToolStripMenuItem";
            this.portToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.portToolStripMenuItem.Text = "Port";
            this.portToolStripMenuItem.Click += new System.EventHandler(this.PortToolStripMenuItem_Click);
            // 
            // ıpGirişToolStripMenuItem
            // 
            this.ıpGirişToolStripMenuItem.Name = "ıpGirişToolStripMenuItem";
            this.ıpGirişToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.ıpGirişToolStripMenuItem.Text = "Ip giriş";
            this.ıpGirişToolStripMenuItem.Click += new System.EventHandler(this.IpGirişToolStripMenuItem_Click);
            // 
            // engelKaldırmaToolStripMenuItem
            // 
            this.engelKaldırmaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.engelKaldırmaToolStripMenuItem1});
            this.engelKaldırmaToolStripMenuItem.Name = "engelKaldırmaToolStripMenuItem";
            this.engelKaldırmaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.engelKaldırmaToolStripMenuItem.Text = "Engel ";
            // 
            // engelKaldırmaToolStripMenuItem1
            // 
            this.engelKaldırmaToolStripMenuItem1.Name = "engelKaldırmaToolStripMenuItem1";
            this.engelKaldırmaToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.engelKaldırmaToolStripMenuItem1.Text = "Engel Kaldırma";
            this.engelKaldırmaToolStripMenuItem1.Click += new System.EventHandler(this.EngelKaldırmaToolStripMenuItem1_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.ÇıkışToolStripMenuItem_Click);
            // 
            // anasayfaToolStripMenuItem
            // 
            this.anasayfaToolStripMenuItem.Name = "anasayfaToolStripMenuItem";
            this.anasayfaToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.anasayfaToolStripMenuItem.Text = "Anasayfa";
            this.anasayfaToolStripMenuItem.Click += new System.EventHandler(this.AnasayfaToolStripMenuItem_Click);
            // 
            // Length
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1012, 581);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView4);
            this.Controls.Add(this.udp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.tcp);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.save);
            this.Controls.Add(this._udp);
            this.Controls.Add(this._tcp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adapters_label);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.adapters_list);
            this.Name = "Length";
            this.Text = "Length";
            this.Load += new System.EventHandler(this.Length_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label udp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label tcp;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.CheckBox _udp;
        private System.Windows.Forms.CheckBox _tcp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label adapters_label;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.ComboBox adapters_list;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ağToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ağıDinleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ıPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erişimeİzinVerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ıpEngelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataLengthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ıpGirişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem engelKaldırmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem engelKaldırmaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anasayfaToolStripMenuItem;
    }
}