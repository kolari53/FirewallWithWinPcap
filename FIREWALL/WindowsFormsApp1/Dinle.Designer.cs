namespace WindowsFormsApp1
{
    partial class Dinle
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dinle));
            this.stop_button = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.CheckBox();
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
            this.anaSayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stop_button
            // 
            this.stop_button.BackColor = System.Drawing.Color.Transparent;
            this.stop_button.Enabled = false;
            this.stop_button.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stop_button.ForeColor = System.Drawing.Color.Black;
            this.stop_button.Location = new System.Drawing.Point(588, 200);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(190, 32);
            this.stop_button.TabIndex = 34;
            this.stop_button.Text = "Durdur";
            this.stop_button.UseVisualStyleBackColor = false;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // save
            // 
            this.save.AutoSize = true;
            this.save.BackColor = System.Drawing.Color.Transparent;
            this.save.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.save.ForeColor = System.Drawing.Color.Black;
            this.save.Location = new System.Drawing.Point(270, 207);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(79, 22);
            this.save.TabIndex = 33;
            this.save.Text = "Kaydet";
            this.save.UseVisualStyleBackColor = false;
            // 
            // _udp
            // 
            this._udp.AutoSize = true;
            this._udp.BackColor = System.Drawing.Color.Transparent;
            this._udp.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this._udp.ForeColor = System.Drawing.Color.Black;
            this._udp.Location = new System.Drawing.Point(324, 125);
            this._udp.Name = "_udp";
            this._udp.Size = new System.Drawing.Size(77, 29);
            this._udp.TabIndex = 32;
            this._udp.Text = "UDP";
            this._udp.UseVisualStyleBackColor = false;
            // 
            // _tcp
            // 
            this._tcp.AutoSize = true;
            this._tcp.BackColor = System.Drawing.Color.Transparent;
            this._tcp.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this._tcp.ForeColor = System.Drawing.Color.Black;
            this._tcp.Location = new System.Drawing.Point(231, 125);
            this._tcp.Name = "_tcp";
            this._tcp.Size = new System.Drawing.Size(72, 29);
            this._tcp.TabIndex = 31;
            this._tcp.Text = "TCP";
            this._tcp.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Filtreyi Seçiniz :";
            // 
            // adapters_label
            // 
            this.adapters_label.AutoSize = true;
            this.adapters_label.BackColor = System.Drawing.Color.Transparent;
            this.adapters_label.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adapters_label.ForeColor = System.Drawing.Color.Black;
            this.adapters_label.Location = new System.Drawing.Point(-2, 34);
            this.adapters_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adapters_label.Name = "adapters_label";
            this.adapters_label.Size = new System.Drawing.Size(307, 25);
            this.adapters_label.TabIndex = 27;
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
            this.listView1.Location = new System.Drawing.Point(92, 301);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(733, 177);
            this.listView1.TabIndex = 26;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Zaman";
            this.columnHeader2.Width = 182;
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
            this.start_button.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.start_button.ForeColor = System.Drawing.Color.Black;
            this.start_button.Location = new System.Drawing.Point(48, 200);
            this.start_button.Margin = new System.Windows.Forms.Padding(4);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(176, 32);
            this.start_button.TabIndex = 25;
            this.start_button.Text = "Başlat";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // adapters_list
            // 
            this.adapters_list.FormattingEnabled = true;
            this.adapters_list.Location = new System.Drawing.Point(313, 41);
            this.adapters_list.Margin = new System.Windows.Forms.Padding(4);
            this.adapters_list.Name = "adapters_list";
            this.adapters_list.Size = new System.Drawing.Size(341, 21);
            this.adapters_list.TabIndex = 24;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaSayfaToolStripMenuItem,
            this.ağToolStripMenuItem,
            this.ıPToolStripMenuItem,
            this.engelKaldırmaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1009, 24);
            this.menuStrip1.TabIndex = 36;
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
            // anaSayfaToolStripMenuItem
            // 
            this.anaSayfaToolStripMenuItem.Name = "anaSayfaToolStripMenuItem";
            this.anaSayfaToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.anaSayfaToolStripMenuItem.Text = "Anasayfa";
            this.anaSayfaToolStripMenuItem.Click += new System.EventHandler(this.AnaSayfaToolStripMenuItem_Click);
            // 
            // Dinle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1009, 490);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.save);
            this.Controls.Add(this._udp);
            this.Controls.Add(this._tcp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adapters_label);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.adapters_list);
            this.Name = "Dinle";
            this.Text = "Dinle";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.CheckBox save;
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
    }
}

