namespace AZandMore
{
    partial class frmNumbers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNumbers));
            this.txtNumName = new System.Windows.Forms.TextBox();
            this.btnName = new System.Windows.Forms.Button();
            this.txtExampleWord = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNumName
            // 
            this.txtNumName.BackColor = System.Drawing.Color.White;
            this.txtNumName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumName.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumName.Location = new System.Drawing.Point(14, 40);
            this.txtNumName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNumName.Name = "txtNumName";
            this.txtNumName.ReadOnly = true;
            this.txtNumName.Size = new System.Drawing.Size(91, 80);
            this.txtNumName.TabIndex = 3;
            this.txtNumName.Text = "A";
            this.txtNumName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNumName_MouseClick);
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(302, 28);
            this.btnName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(83, 31);
            this.btnName.TabIndex = 5;
            this.btnName.Text = "Name";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // txtExampleWord
            // 
            this.txtExampleWord.BackColor = System.Drawing.Color.White;
            this.txtExampleWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExampleWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtExampleWord.Location = new System.Drawing.Point(135, 82);
            this.txtExampleWord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtExampleWord.Name = "txtExampleWord";
            this.txtExampleWord.ReadOnly = true;
            this.txtExampleWord.Size = new System.Drawing.Size(249, 35);
            this.txtExampleWord.TabIndex = 7;
            this.txtExampleWord.Text = "ANBDSVA asdkjha";
            this.txtExampleWord.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtExampleWord_MouseClick);
            // 
            // frmNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 162);
            this.Controls.Add(this.txtExampleWord);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.txtNumName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmNumbers";
            this.Text = "Numbers";
            this.Load += new System.EventHandler(this.frmNumbers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumName;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.TextBox txtExampleWord;
    }
}