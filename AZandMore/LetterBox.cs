using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AZandMore
{
    class LetterBox:TextBox
    {
        public LetterBox(string letter)
        {
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(53, 141);
            this.Name = "label1";
            this.Size = new System.Drawing.Size(80, 80);
            this.Text = letter;
            this.TabStop = true;
            this.TextAlign = HorizontalAlignment.Center;
            this.ReadOnly = true;
        } 
    }
}
