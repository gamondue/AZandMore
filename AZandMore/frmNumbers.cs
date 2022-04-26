using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AZandMore
{
    public partial class frmNumbers : Form
    {
        public frmNumbers()
        {
            InitializeComponent();
        }
        Number num;
        System.Media.SoundPlayer suonatore = new System.Media.SoundPlayer();
        string path;

        
        public frmNumbers(Number n, string language)
        {
            
            InitializeComponent();

            num= n;
            txtNumName.Text = n.name;            
            txtExampleWord.Text = n.exampleWord;           

            this.Text = n.name + " " + language;
        }

        public void playNumberName()
        {
            try
            {
                suonatore.SoundLocation = Path.Combine(Global.PathAudio, num.exampleWordPronunciation);
                suonatore.Play();
            }
            catch { Console.WriteLine("Missing file " + num.name); }
        }

        private void frmNumbers_Load(object sender, EventArgs e)
        {

        }

        private void btnName_Click(object sender, EventArgs e)
        {
            playNumberName();
        }

        private void txtExampleWord_MouseClick(object sender, MouseEventArgs e)
        {
            playNumberName();
        }

        private void txtNumName_MouseClick(object sender, MouseEventArgs e)
        {
            playNumberName();
        }

       
    }
}
