using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace HtmlEditor
{

    public partial class UserControl1 : UserControl
    {
        string oldFile = null;

        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            yenidenBoyutlandir();
        }

        public void yenidenBoyutlandir()
        {
            splitContainer1.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height - 100);
            htmlTxt.Size = new Size(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height - 100);
            webBrowser1.Size = new Size(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height - 100);
        }

        public void executeProgram()
        {
            webBrowser1.DocumentText = htmlTxt.Text;
        }

        public void geriAl()
        {
            htmlTxt.Undo();
        }
        public void ileriAl()
        {
            htmlTxt.Redo();
        }
        public void FindMyText(string text)
        {
            int indextotext = 0;

            while (true)
            {
                if (text.Length > 0)
                {
                    indextotext = htmlTxt.Find(text, indextotext + 1, RichTextBoxFinds.None);
                    if (indextotext == -1) break;
                    htmlTxt.SelectionBackColor = Color.Green;
                    htmlTxt.SelectionStart = indextotext;
                    htmlTxt.SelectionLength = text.Length;
                    
                }
            }
            htmlTxt.SelectionLength = 0;
            timer1.Enabled = true;

        }

        public void Temizle()
        {

        }
        public void Kes()
        {
            htmlTxt.Cut();
        }
        public void Kopyala()
        {
            htmlTxt.Copy();
        }
        public void Yapistir()
        {
            htmlTxt.Paste();
        }
        public void Sil()
        {
            htmlTxt.Clear();
        }

        public void kaydet()
        {
            if (oldFile != null)
            {
                SaveFileDialog savefiledialog1 = new SaveFileDialog();
                savefiledialog1.Filter = "html dosyalar(*.html) | *.html";
                htmlTxt.SaveFile(oldFile, RichTextBoxStreamType.PlainText);
            } else
            {
                farkliKaydet();
            }
        }
        public void farkliKaydet()
        {
            SaveFileDialog savefiledialog1 = new SaveFileDialog();
            savefiledialog1.Filter = "html dosyalar(*.html) | *.html";

            if (savefiledialog1.ShowDialog() == DialogResult.OK)            
                htmlTxt.SaveFile(savefiledialog1.FileName, RichTextBoxStreamType.PlainText);

            oldFile = savefiledialog1.FileName;
        }

        public string ac()
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "HTML dosyası | *.html";
            file.Title = "Html dosyasını seçiniz";
            if (file.ShowDialog() == DialogResult.OK)
                htmlTxt.Text = File.ReadAllText(file.FileName, Encoding.Default);
            oldFile = file.FileName;
            return file.SafeFileName;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            timer1.Enabled = false;           
        }

        private void htmlTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void htmlTxt_KeyUp(object sender, KeyEventArgs e)
        {
               }

        private void htmlTxt_KeyDown(object sender, KeyEventArgs e)
        {
  
        }
    }
}
