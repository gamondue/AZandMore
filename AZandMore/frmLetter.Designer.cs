namespace AZandMore
{
    partial class frmLetter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLetter));
            this.txtCapitalLetter = new System.Windows.Forms.TextBox();
            this.txtLowerLett = new System.Windows.Forms.TextBox();
            this.picExample = new System.Windows.Forms.PictureBox();
            this.btnName = new System.Windows.Forms.Button();
            this.btnSound = new System.Windows.Forms.Button();
            this.txtExampleWord = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picExample)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCapitalLetter
            // 
            this.txtCapitalLetter.BackColor = System.Drawing.Color.White;
            this.txtCapitalLetter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCapitalLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCapitalLetter.Location = new System.Drawing.Point(14, 14);
            this.txtCapitalLetter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCapitalLetter.Name = "txtCapitalLetter";
            this.txtCapitalLetter.ReadOnly = true;
            this.txtCapitalLetter.Size = new System.Drawing.Size(93, 80);
            this.txtCapitalLetter.TabIndex = 1;
            this.txtCapitalLetter.Text = "A";
            this.txtCapitalLetter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCapitalLetter.Click += new System.EventHandler(this.btnName_Click);
            // 
            // txtLowerLett
            // 
            this.txtLowerLett.BackColor = System.Drawing.Color.White;
            this.txtLowerLett.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLowerLett.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLowerLett.Location = new System.Drawing.Point(114, 14);
            this.txtLowerLett.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLowerLett.Name = "txtLowerLett";
            this.txtLowerLett.ReadOnly = true;
            this.txtLowerLett.Size = new System.Drawing.Size(93, 80);
            this.txtLowerLett.TabIndex = 2;
            this.txtLowerLett.Text = "A";
            this.txtLowerLett.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLowerLett.Click += new System.EventHandler(this.txtLetters_Click);
            // 
            // picExample
            // 
            this.picExample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picExample.Location = new System.Drawing.Point(14, 153);
            this.picExample.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picExample.Name = "picExample";
            this.picExample.Size = new System.Drawing.Size(93, 92);
            this.picExample.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExample.TabIndex = 3;
            this.picExample.TabStop = false;
            this.picExample.Click += new System.EventHandler(this.Example_Click);
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(287, 14);
            this.btnName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(83, 31);
            this.btnName.TabIndex = 4;
            this.btnName.Text = "Name";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // btnSound
            // 
            this.btnSound.Location = new System.Drawing.Point(287, 75);
            this.btnSound.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(83, 31);
            this.btnSound.TabIndex = 5;
            this.btnSound.Text = "Sound";
            this.btnSound.UseVisualStyleBackColor = true;
            this.btnSound.Click += new System.EventHandler(this.txtLetters_Click);
            // 
            // txtExampleWord
            // 
            this.txtExampleWord.BackColor = System.Drawing.Color.White;
            this.txtExampleWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExampleWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtExampleWord.Location = new System.Drawing.Point(114, 153);
            this.txtExampleWord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtExampleWord.Name = "txtExampleWord";
            this.txtExampleWord.ReadOnly = true;
            this.txtExampleWord.Size = new System.Drawing.Size(255, 35);
            this.txtExampleWord.TabIndex = 6;
            this.txtExampleWord.Text = "ANBDSVA asdkjha";
            this.txtExampleWord.Click += new System.EventHandler(this.Example_Click);
            // 
            // frmLetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(394, 260);
            this.Controls.Add(this.txtExampleWord);
            this.Controls.Add(this.btnSound);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.picExample);
            this.Controls.Add(this.txtLowerLett);
            this.Controls.Add(this.txtCapitalLetter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmLetter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Letter";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmLetter_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.picExample)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCapitalLetter;
        private System.Windows.Forms.TextBox txtLowerLett;
        private System.Windows.Forms.PictureBox picExample;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Button btnSound;
        private System.Windows.Forms.TextBox txtExampleWord;
    }
}