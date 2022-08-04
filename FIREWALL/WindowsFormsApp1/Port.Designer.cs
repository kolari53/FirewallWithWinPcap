namespace WindowsFormsApp1
{
    partial class Port
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Port));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stop_button = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.CheckBox();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adapters_list = new System.Windows.Forms.ComboBox();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._udp = new System.Windows.Forms.CheckBox();
            this._tcp = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.adapters_label = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.start_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anaSayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(861, 368);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(156, 147);
            this.listBox1.TabIndex = 40;
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8});
            this.listView3.Location = new System.Drawing.Point(688, 368);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(144, 158);
            this.listView3.TabIndex = 39;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "TCP Portu";
            this.columnHeader8.Width = 106;
            // 
            // pro
            // 
            this.pro.Text = "pro";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "des port";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "src port";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 142;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Src ip";
            this.columnHeader1.Width = 182;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader7,
            this.columnHeader9,
            this.pro});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(125, 171);
            this.listView2.Margin = new System.Windows.Forms.Padding(4);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(537, 177);
            this.listView2.TabIndex = 38;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // stop_button
            // 
            this.stop_button.BackColor = System.Drawing.Color.Transparent;
            this.stop_button.Enabled = false;
            this.stop_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.stop_button.ForeColor = System.Drawing.Color.Black;
            this.stop_button.Location = new System.Drawing.Point(449, 118);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(190, 32);
            this.stop_button.TabIndex = 37;
            this.stop_button.Text = "Stop ";
            this.stop_button.UseVisualStyleBackColor = false;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // save
            // 
            this.save.AutoSize = true;
            this.save.BackColor = System.Drawing.Color.Transparent;
            this.save.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(118, 84);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(65, 22);
            this.save.TabIndex = 36;
            this.save.Text = "kayıt";
            this.save.UseVisualStyleBackColor = false;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Protocol";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 150;
            // 
            // adapters_list
            // 
            this.adapters_list.FormattingEnabled = true;
            this.adapters_list.Location = new System.Drawing.Point(321, 34);
            this.adapters_list.Margin = new System.Windows.Forms.Padding(4);
            this.adapters_list.Name = "adapters_list";
            this.adapters_list.Size = new System.Drawing.Size(341, 21);
            this.adapters_list.TabIndex = 27;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Destination";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 142;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Source";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 142;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Zaman";
            this.columnHeader2.Width = 182;
            // 
            // _udp
            // 
            this._udp.AutoSize = true;
            this._udp.BackColor = System.Drawing.Color.Transparent;
            this._udp.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this._udp.ForeColor = System.Drawing.Color.White;
            this._udp.Location = new System.Drawing.Point(307, 54);
            this._udp.Name = "_udp";
            this._udp.Size = new System.Drawing.Size(52, 20);
            this._udp.TabIndex = 35;
            this._udp.Text = "UDP";
            this._udp.UseVisualStyleBackColor = false;
            // 
            // _tcp
            // 
            this._tcp.AutoSize = true;
            this._tcp.BackColor = System.Drawing.Color.Transparent;
            this._tcp.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this._tcp.ForeColor = System.Drawing.Color.White;
            this._tcp.Location = new System.Drawing.Point(237, 54);
            this._tcp.Name = "_tcp";
            this._tcp.Size = new System.Drawing.Size(50, 20);
            this._tcp.TabIndex = 34;
            this._tcp.Text = "TCP";
            this._tcp.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(101, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "Filitre seçin";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 370);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(496, 168);
            this.textBox1.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(2, 368);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "Protocol Info :";
            // 
            // adapters_label
            // 
            this.adapters_label.AutoSize = true;
            this.adapters_label.BackColor = System.Drawing.Color.Transparent;
            this.adapters_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.adapters_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.adapters_label.Location = new System.Drawing.Point(101, 32);
            this.adapters_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adapters_label.Name = "adapters_label";
            this.adapters_label.Size = new System.Drawing.Size(166, 19);
            this.adapters_label.TabIndex = 30;
            this.adapters_label.Text = " Network Adeptar :";
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
            this.listView1.Location = new System.Drawing.Point(125, 171);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(707, 177);
            this.listView1.TabIndex = 29;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Length";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 115;
            // 
            // start_button
            // 
            this.start_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.start_button.ForeColor = System.Drawing.Color.Black;
            this.start_button.Location = new System.Drawing.Point(252, 118);
            this.start_button.Margin = new System.Windows.Forms.Padding(4);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(176, 32);
            this.start_button.TabIndex = 28;
            this.start_button.Text = "Start ";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(998, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 51);
            this.button2.TabIndex = 44;
            this.button2.Text = "Listedeki Portları Engelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaSayfaToolStripMenuItem,
            this.ağToolStripMenuItem,
            this.ıPToolStripMenuItem,
            this.engelKaldırmaToolStripMenuItem,
            this.çıkışToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1168, 24);
            this.menuStrip1.TabIndex = 46;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anaSayfaToolStripMenuItem
            // 
            this.anaSayfaToolStripMenuItem.Name = "anaSayfaToolStripMenuItem";
            this.anaSayfaToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.anaSayfaToolStripMenuItem.Text = "Anasayfa";
            this.anaSayfaToolStripMenuItem.Click += new System.EventHandler(this.AnaSayfaToolStripMenuItem_Click);
            // 
            // ağToolStripMenuItem
            // 
            this.ağToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ağıDinleToolStripMenuItem});
            this.ağToolStripMenuItem.Name = "ağToolStripMenuItem";
            this.ağToolStripMenuItem.Size = new System.Drawing.Size(34, 20);
            this.ağToolStripMenuItem.Text = "Ağ";
            this.ağToolStripMenuItem.Click += new System.EventHandler(this.AğToolStripMenuItem_Click);
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
            this.ıpEngelleToolStripMenuItem.Click += new System.EventHandler(this.IpEngelleToolStripMenuItem_Click);
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
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(995, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 40);
            this.button1.TabIndex = 47;
            this.button1.Text = "Elle Giriş Engelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(873, 270);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 48;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(998, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 49;
            this.button3.Text = "Engel Aç";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Port
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1168, 586);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.save);
            this.Controls.Add(this.adapters_list);
            this.Controls.Add(this._udp);
            this.Controls.Add(this._tcp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adapters_label);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.start_button);
            this.Name = "Port";
            this.Text = "Port";
            this.Load += new System.EventHandler(this.Port_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader pro;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listView2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.CheckBox save;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ComboBox adapters_list;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.CheckBox _udp;
        private System.Windows.Forms.CheckBox _tcp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label adapters_label;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button button2;
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
        private System.Windows.Forms.ToolStripMenuItem anaSayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
    }
}