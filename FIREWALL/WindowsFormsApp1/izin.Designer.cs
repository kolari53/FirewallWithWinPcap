namespace WindowsFormsApp1
{
    partial class izin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(izin));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(173, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 27);
            this.button3.TabIndex = 11;
            this.button3.Text = "İzin Ver";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(173, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 34);
            this.button2.TabIndex = 10;
            this.button2.Text = "veri girişi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(488, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(106, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Erişimine izin verilecek IP\'yi giriniz : ";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(488, 108);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(146, 186);
            this.listBox1.TabIndex = 7;
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
            this.menuStrip1.Size = new System.Drawing.Size(723, 24);
            this.menuStrip1.TabIndex = 12;
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
            // izin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(723, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "izin";
            this.Text = "izin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
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