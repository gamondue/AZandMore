using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AZandMore
{
    public partial class frmLetter : Form
    {
        Letter lett;
        System.Media.SoundPlayer suonatore = new System.Media.SoundPlayer();
        public frmLetter(Letter l, string language)
        {
            InitializeComponent();

            lett = l;
            txtCapitalLetter.Text = l.UpperCaseLetter;
            txtLowerLett.Text = l.LowerCaseLetter;
            txtExampleWord.Text = l.ExampleWord;

            try
            {
                picExample.Image = new Bitmap(l.ExampleWordImage);
            }
            catch { Console.WriteLine("Missing file " + l.ExampleWordImage); }

            this.Text = l.UpperCaseLetter + " " + language;
        }
        public void playLetterName()
        {
            try
            {
                suonatore.SoundLocation = Path.Combine(Global.PathAudio, lett.Name);
                suonatore.Play();
            }
            catch { Console.WriteLine("Missing file " + lett.Name); }
        }
        private void playLetterPronunciation()
        {
            try
            {
                suonatore.SoundLocation = Path.Combine(Global.PathAudio, lett.Pronunciation);
                suonatore.Play();
            }
            catch { Console.WriteLine("Missing file " + lett.Pronunciation); }
        }
        private void playExampleWord()
        {
            try
            {
                suonatore.SoundLocation = Path.Combine(Global.PathAudio, lett.ExampleWordPronunciation);
                suonatore.Play();
            }
            catch { Console.WriteLine("Missing file " + lett.ExampleWordPronunciation); }
        }
        private void frmLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' && ((Control)sender).Name != "txtExampleWord"
                && ((Control)sender).Name != "picExample")
            {
                playLetterPronunciation();
            }
        }
        private void txtLetters_Click(object sender, EventArgs e)
        {
            playLetterPronunciation();
        }
        private void Example_Click(object sender, EventArgs e)
        {
            playExampleWord();
        }
        private void btnName_Click(object sender, EventArgs e)
        {
            playLetterName();
        }
    }
}
