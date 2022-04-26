namespace AZandMore
{
    partial class frmAZandMore
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAZandMore));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.AlphabetMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NumbersMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtLett = new System.Windows.Forms.TextBox();
            this.picFlag = new System.Windows.Forms.PictureBox();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AlphabetMenu,
            this.NumbersMenu,
            this.HelpMenu});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(788, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // AlphabetMenu
            // 
            this.AlphabetMenu.Name = "AlphabetMenu";
            this.AlphabetMenu.Size = new System.Drawing.Size(67, 20);
            this.AlphabetMenu.Text = "Alphabet";
            // 
            // NumbersMenu
            // 
            this.NumbersMenu.Name = "NumbersMenu";
            this.NumbersMenu.Size = new System.Drawing.Size(68, 20);
            this.NumbersMenu.Text = "Numbers";
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(44, 20);
            this.HelpMenu.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // txtLett
            // 
            this.txtLett.BackColor = System.Drawing.Color.White;
            this.txtLett.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLett.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLett.Location = new System.Drawing.Point(14, 210);
            this.txtLett.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLett.Name = "txtLett";
            this.txtLett.ReadOnly = true;
            this.txtLett.Size = new System.Drawing.Size(93, 80);
            this.txtLett.TabIndex = 0;
            this.txtLett.Text = "A";
            this.txtLett.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLett.Visible = false;
            this.txtLett.DoubleClick += new System.EventHandler(this.txtLett_DoubleClick);
            this.txtLett.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLett_KeyPress);
            this.txtLett.MouseEnter += new System.EventHandler(this.txtLett_MouseEnter);
            // 
            // picFlag
            // 
            this.picFlag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picFlag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.picFlag.Location = new System.Drawing.Point(1, 29);
            this.picFlag.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picFlag.Name = "picFlag";
            this.picFlag.Size = new System.Drawing.Size(785, 524);
            this.picFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFlag.TabIndex = 1;
            this.picFlag.TabStop = false;
            // 
            // frmAZandMore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(788, 552);
            this.Controls.Add(this.txtLett);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.picFlag);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmAZandMore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "A-Z and more";
            this.Load += new System.EventHandler(this.frmAZandMore_Load);
            this.Resize += new System.EventHandler(this.frmAZandMore_Resize);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFlag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem AlphabetMenu;
        private System.Windows.Forms.TextBox txtLett;
        private System.Windows.Forms.PictureBox picFlag;
        private System.Windows.Forms.ToolStripMenuItem NumbersMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

