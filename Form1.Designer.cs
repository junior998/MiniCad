namespace mini_cas_v3
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tavola_colori = new System.Windows.Forms.ColorDialog();
            this.barra_strumenti = new System.Windows.Forms.ToolStrip();
            this.punti_bottone = new System.Windows.Forms.ToolStripButton();
            this.linea_bottone = new System.Windows.Forms.ToolStripButton();
            this.rettangolo_bottone = new System.Windows.Forms.ToolStripButton();
            this.quadrato_bottone = new System.Windows.Forms.ToolStripButton();
            this.elissi_button = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.figureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puntiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rettangoliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quadratiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellissiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.strumentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opzioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apri_file = new System.Windows.Forms.OpenFileDialog();
            this.barra_strumenti.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // barra_strumenti
            // 
            this.barra_strumenti.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.barra_strumenti.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barra_strumenti.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.barra_strumenti.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.punti_bottone,
            this.linea_bottone,
            this.rettangolo_bottone,
            this.quadrato_bottone,
            this.elissi_button});
            this.barra_strumenti.Location = new System.Drawing.Point(0, 257);
            this.barra_strumenti.Name = "barra_strumenti";
            this.barra_strumenti.Size = new System.Drawing.Size(446, 27);
            this.barra_strumenti.TabIndex = 0;
            this.barra_strumenti.Text = "Barra degli strumenti";
            // 
            // punti_bottone
            // 
            this.punti_bottone.Checked = true;
            this.punti_bottone.CheckState = System.Windows.Forms.CheckState.Checked;
            this.punti_bottone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.punti_bottone.Image = ((System.Drawing.Image)(resources.GetObject("punti_bottone.Image")));
            this.punti_bottone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.punti_bottone.Name = "punti_bottone";
            this.punti_bottone.Size = new System.Drawing.Size(24, 24);
            this.punti_bottone.Text = "Punto";
            this.punti_bottone.Click += new System.EventHandler(this.Scegli_figura_Click);
            // 
            // linea_bottone
            // 
            this.linea_bottone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.linea_bottone.Image = ((System.Drawing.Image)(resources.GetObject("linea_bottone.Image")));
            this.linea_bottone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.linea_bottone.Name = "linea_bottone";
            this.linea_bottone.Size = new System.Drawing.Size(24, 24);
            this.linea_bottone.Text = "Linea";
            this.linea_bottone.Click += new System.EventHandler(this.Scegli_figura_Click);
            // 
            // rettangolo_bottone
            // 
            this.rettangolo_bottone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rettangolo_bottone.Image = ((System.Drawing.Image)(resources.GetObject("rettangolo_bottone.Image")));
            this.rettangolo_bottone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rettangolo_bottone.Name = "rettangolo_bottone";
            this.rettangolo_bottone.Size = new System.Drawing.Size(24, 24);
            this.rettangolo_bottone.Text = "Rettangolo";
            this.rettangolo_bottone.Click += new System.EventHandler(this.Scegli_figura_Click);
            // 
            // quadrato_bottone
            // 
            this.quadrato_bottone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.quadrato_bottone.Image = ((System.Drawing.Image)(resources.GetObject("quadrato_bottone.Image")));
            this.quadrato_bottone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.quadrato_bottone.Name = "quadrato_bottone";
            this.quadrato_bottone.Size = new System.Drawing.Size(24, 24);
            this.quadrato_bottone.Text = "Quadrato";
            this.quadrato_bottone.Click += new System.EventHandler(this.Scegli_figura_Click);
            // 
            // elissi_button
            // 
            this.elissi_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.elissi_button.Image = ((System.Drawing.Image)(resources.GetObject("elissi_button.Image")));
            this.elissi_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.elissi_button.Name = "elissi_button";
            this.elissi_button.Size = new System.Drawing.Size(24, 24);
            this.elissi_button.Text = "Ellisse";
            this.elissi_button.Click += new System.EventHandler(this.Scegli_figura_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.barra_strumenti);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(446, 284);
            this.toolStripContainer1.ContentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.toolStripContainer1.ContentPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.toolStripContainer1.ContentPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.toolStripContainer1.ContentPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.toolStripContainer1.ContentPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 26);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(446, 309);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.figureToolStripMenuItem,
            this.strumentiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(446, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apriToolStripMenuItem,
            this.salvaToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // apriToolStripMenuItem
            // 
            this.apriToolStripMenuItem.Name = "apriToolStripMenuItem";
            this.apriToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F12)));
            this.apriToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.apriToolStripMenuItem.Text = "Apri ";
            this.apriToolStripMenuItem.Click += new System.EventHandler(this.apriToolStripMenuItem_Click);
            // 
            // salvaToolStripMenuItem
            // 
            this.salvaToolStripMenuItem.Name = "salvaToolStripMenuItem";
            this.salvaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.salvaToolStripMenuItem.Text = "Salva";
            // 
            // figureToolStripMenuItem
            // 
            this.figureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.puntiToolStripMenuItem,
            this.lineeToolStripMenuItem,
            this.rettangoliToolStripMenuItem,
            this.quadratiToolStripMenuItem,
            this.ellissiToolStripMenuItem,
            this.toolStripComboBox1});
            this.figureToolStripMenuItem.Name = "figureToolStripMenuItem";
            this.figureToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.figureToolStripMenuItem.Text = "Figure";
            // 
            // puntiToolStripMenuItem
            // 
            this.puntiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("puntiToolStripMenuItem.Image")));
            this.puntiToolStripMenuItem.Name = "puntiToolStripMenuItem";
            this.puntiToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.puntiToolStripMenuItem.Text = "Punti";
            // 
            // lineeToolStripMenuItem
            // 
            this.lineeToolStripMenuItem.Name = "lineeToolStripMenuItem";
            this.lineeToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.lineeToolStripMenuItem.Text = "Linee";
            // 
            // rettangoliToolStripMenuItem
            // 
            this.rettangoliToolStripMenuItem.Name = "rettangoliToolStripMenuItem";
            this.rettangoliToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.rettangoliToolStripMenuItem.Text = "Rettangoli";
            // 
            // quadratiToolStripMenuItem
            // 
            this.quadratiToolStripMenuItem.Name = "quadratiToolStripMenuItem";
            this.quadratiToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.quadratiToolStripMenuItem.Text = "Quadrati";
            // 
            // ellissiToolStripMenuItem
            // 
            this.ellissiToolStripMenuItem.Name = "ellissiToolStripMenuItem";
            this.ellissiToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.ellissiToolStripMenuItem.Text = "Ellissi";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Triangoli",
            "Pentagoni"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.Text = "Poligoni";
            // 
            // strumentiToolStripMenuItem
            // 
            this.strumentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opzioniToolStripMenuItem});
            this.strumentiToolStripMenuItem.Name = "strumentiToolStripMenuItem";
            this.strumentiToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.strumentiToolStripMenuItem.Text = "Strumenti";
            // 
            // opzioniToolStripMenuItem
            // 
            this.opzioniToolStripMenuItem.Name = "opzioniToolStripMenuItem";
            this.opzioniToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.opzioniToolStripMenuItem.Text = "Opzioni";
            this.opzioniToolStripMenuItem.Click += new System.EventHandler(this.opzioniToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(446, 335);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.barra_strumenti.ResumeLayout(false);
            this.barra_strumenti.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog tavola_colori;
        private System.Windows.Forms.ToolStrip barra_strumenti;
        private System.Windows.Forms.ToolStripButton punti_bottone;
        private System.Windows.Forms.ToolStripButton linea_bottone;
        private System.Windows.Forms.ToolStripButton rettangolo_bottone;
        private System.Windows.Forms.ToolStripButton quadrato_bottone;
        private System.Windows.Forms.ToolStripButton elissi_button;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem figureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puntiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rettangoliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quadratiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ellissiToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.OpenFileDialog apri_file;
        private System.Windows.Forms.ToolStripMenuItem strumentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opzioniToolStripMenuItem;
    }
}

