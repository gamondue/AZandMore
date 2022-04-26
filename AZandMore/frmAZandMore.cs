using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AZandMore
{
    public partial class frmAZandMore : Form
    {
        LetterBox[] letterBoxes;
        string[,] letters;

        string currentLanguage;
        frmLetter tempLett;

        private bool partenza = true;

        public frmAZandMore()
        {
            InitializeComponent();
#if DEBUG
            Global.PathRoot = @"D:\Develop\Git\AZandMore\AZandMore_Distributable Folder\";
#else
            Global.PathRoot = Path.GetDirectoryName(Application.ExecutablePath);
#endif
        }
        private void frmAZandMore_Load(object sender, EventArgs e)
        {
            Global.PathFiles = Path.Combine(Global.PathRoot, "Files");
            Global.PathLetters = Path.Combine(Global.PathFiles, "Letters");
            Global.PathNumbers = Path.Combine(Global.PathFiles, "Numbers");

            AggiuntaMenu(Global.PathLetters, AlphabetMenu);
            AggiuntaMenu(Global.PathNumbers, NumbersMenu);

            partenza = false;
        }
        private void MenuItemAlphabet_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = (ToolStripMenuItem) sender;
            currentLanguage = menu.Text;
            Global.PathLanguage = Path.Combine(Global.PathLetters, currentLanguage);
            Global.PathImages = Path.Combine(Global.PathLanguage, "Images");
            Global.PathAudio = Path.Combine(Global.PathLanguage, "Audio");
            //this.BackgroundImage = null;
            picFlag.Image = null;
            // lettura del file dell'alfabeto
            letters = gamon.FileDiTesto.FileInMatrice(
                Path.Combine(Global.PathLanguage, "AZ_letters_" + currentLanguage + ".tsv"), '\t');
            removeLetterBoxes();

            try
            {
                if (letters != null)
                {
                    letterBoxes = new LetterBox[letters.GetLength(0)];
                }
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (letters != null)
            {
                for (int i = 0; i < letters.GetLength(0); i++)
                {
                    letterBoxes[i] = new LetterBox(letters[i, 0]);
                    this.Controls.Add(letterBoxes[i]);
                    letterBoxes[i].KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLett_KeyPress);
                    letterBoxes[i].DoubleClick += new System.EventHandler(this.txtLett_DoubleClick);
                    letterBoxes[i].Click += new System.EventHandler(this.txtLett_Click);

                    letterBoxes[i].MouseEnter += new System.EventHandler(this.txtLett_MouseEnter);
                    letterBoxes[i].TabIndex = i;

                    // nuovo oggetto di classe Letter, da associare al LetterBox tramite la proprietà Tag:
                    Letter l = new Letter(letters[i, 0], letters[i, 1], letters[i, 2], letters[i, 3]
                                            , letters[i, 4], letters[i, 5],
                                            Path.Combine(Global.PathImages, letters[i, 6]), "");
                    // carattere fonetico per ora non usato
                    letterBoxes[i].Tag = l;
                }
            }
            arrangeLetterBoxes();
            string bandiera = Path.Combine(Global.PathLanguage, "Flag_" + currentLanguage + ".png");
            if (File.Exists(bandiera))
            {
                picFlag.SendToBack();
                picFlag.Image = new Bitmap(bandiera);
            }
        }
        private void MenuItemNumber_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = (ToolStripMenuItem)sender;
            currentLanguage = menu.Text;
            Global.PathLanguage = Path.Combine(Global.PathNumbers, currentLanguage);
            Global.PathImages = Path.Combine(Global.PathLanguage, "Images");
            Global.PathAudio = Path.Combine(Global.PathLanguage, "Audio");
            //this.BackgroundImage = null;
            picFlag.Image = null;
            removeLetterBoxes();
            // lettura del file dei numeri
            letters = gamon.FileDiTesto.FileInMatrice(
                Path.Combine(Global.PathLanguage, "AZ_numbers_" + currentLanguage + ".tsv"), '\t');
            try
            {
                if (letters != null)
                {
                    letterBoxes = new LetterBox[letters.GetLength(0)];
                }
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (letters != null)
            {
                for (int i = 0; i < letters.GetLength(0); i++)
                {
                    letterBoxes[i] = new LetterBox(letters[i, 0]);
                    this.Controls.Add(letterBoxes[i]);
                    letterBoxes[i].KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
                    letterBoxes[i].DoubleClick += new System.EventHandler(this.txtNum_DoubleClick);
                    letterBoxes[i].Click += new System.EventHandler(this.txtNum_Click);

                    letterBoxes[i].TabIndex = i;

                    // nuovo oggetto di classe Number, da associare al LetterBox tramite la proprietà Tag:
                    Number n = new Number(letters[i, 0], letters[i, 1], letters[i, 2]);
                    // carattere fonetico per ora non usato
                    letterBoxes[i].Tag = n;
                }
            }
            arrangeLetterBoxes();
            string bandiera = Path.Combine(Global.PathLanguage, "Flag_" + currentLanguage + ".png");
            if (File.Exists(bandiera))
            { 
                picFlag.SendToBack();
                picFlag.Image = new Bitmap(bandiera);
            }
        }
        private void removeLetterBoxes()
        {
            if (letterBoxes != null)
            {
                for (int i = 0; i < letterBoxes.Length; i++)
                {
                    // toglie dal form le LetterBox che ci sono ora
                    this.Controls.Remove (letterBoxes[i]);
                }
            }
        }
        private void arrangeLetterBoxes()
        {
            this.BackgroundImage = null;
            int xLetter = 10, yLetter = menu.Height + 10;
            if (letters != null)
            {
                for (int i = 0; i < letters.GetLength(0); i++)
                {
                    if (xLetter + letterBoxes[0].Width > this.Width)
                    {
                        xLetter = 10;
                        yLetter += letterBoxes[i - 1].Height + 10;
                    }
                    // mette in posizione la LetterBox
                    letterBoxes[i].Location = new Point(xLetter, yLetter);
                    // nuova posizione della LetterBox
                    xLetter += letterBoxes[i].Width + 10;
                }
            }
            this.BackgroundImage = null;
        }
        private void frmAZandMore_Resize(object sender, EventArgs e)
        {
            if (!partenza)
                arrangeLetterBoxes();
        }
        private void txtLett_KeyPress(object sender, KeyPressEventArgs e)
        {
            LetterBox box = (LetterBox) sender;
            frmLetter lett = new frmLetter((Letter) box.Tag, currentLanguage);
            lett.Show();
        }
        private void txtLett_DoubleClick(object sender, EventArgs e)
        {
            LetterBox box = (LetterBox)sender;
            frmLetter lett = new frmLetter((Letter)box.Tag, currentLanguage);
            lett.Location = new Point(box.Location.X + box.Size.Width + 5, 
                                        box.Location.Y + box.Size.Height/2 + 20);
            lett.Show();
        }
        private void txtLett_Click(object sender, EventArgs e)
        {
            LetterBox box = (LetterBox)sender;
            frmLetter lett = new frmLetter((Letter)box.Tag, currentLanguage);
            try
            {
                tempLett.playLetterName();
            }
            catch { Console.WriteLine("Missing audio file " + lett.Text); }
        }
        private void txtLett_MouseEnter(object sender, EventArgs e)
        {
            LetterBox box = (LetterBox)sender;
            tempLett = new frmLetter((Letter)box.Tag, currentLanguage);
            tempLett.Location = new Point(this.Location.X+this.Size.Width , this.Location.Y);
            
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gamon.frmAbout f = new gamon.frmAbout();
            f.Show();
        }
        public void AggiuntaMenu(string path, ToolStripMenuItem ItemPadre)
        {
            //aggiorno il menu con i linguaggi Languages Pack
            string[] Cartelle = System.IO.Directory.GetDirectories(path);
            //for (int i = 0; i < languages.Length; i++)
            foreach (string cartella in Cartelle)
            {
                string nome = new DirectoryInfo(cartella).Name;
                creaMenuItem(nome, ItemPadre);
            }
        }
        private ToolStripMenuItem creaMenuItem(string testo, ToolStripMenuItem ItemPadre)
        {
            ToolStripMenuItem menuItem = new ToolStripMenuItem(testo);
            ItemPadre.DropDownItems.AddRange
                (new System.Windows.Forms.ToolStripItem[] { menuItem }
                );

            menuItem.Name = "primoMenuToolStripMenuItem";
            menuItem.Size = new System.Drawing.Size(155, 22);
            if (ItemPadre == AlphabetMenu)
                menuItem.Click += new System.EventHandler(this.MenuItemAlphabet_Click);
            else
                menuItem.Click += new System.EventHandler(this.MenuItemNumber_Click);

            return menuItem;
        }
        private void txtNum_KeyPress(object sender, EventArgs e)
        {
            LetterBox box = (LetterBox)sender;
            frmNumbers num = new frmNumbers((Number)box.Tag, currentLanguage);
            num.Show(); 
        }
        private void txtNum_DoubleClick(object sender, EventArgs e)
        {
            LetterBox box = (LetterBox)sender;
            frmNumbers num = new frmNumbers((Number)box.Tag, currentLanguage);
            num.Location = new Point(box.Location.X + box.Size.Width + 5, 
                                        box.Location.Y + box.Size.Height/2 + 20);
            num.Show();
        }
        private void txtNum_Click(object sender, EventArgs e)
        {
            LetterBox box = (LetterBox)sender;            
            frmNumbers num = new frmNumbers((Number)box.Tag, currentLanguage);      
            try
            {
                num.playNumberName();
            }
            catch { Console.WriteLine("Missing audio file " + num.Text); }
        }
    }
}
