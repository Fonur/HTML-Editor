using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace HtmlEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        UserControl1[] myUserControl = new UserControl1[10];

        Boolean[] sekmeler = {
            false,false,false,false,false,false,false,false,false,false
        };

        private void çalıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myUserControl[tabControl1.SelectedIndex].executeProgram();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.RemoveAt(0);
            tabControl1.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height-100);
            userControl11.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            if (tabControl1.TabPages.Count != 0)
                myUserControl[tabControl1.SelectedIndex].yenidenBoyutlandir();
        }

        private void htmlTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myUserControl[tabControl1.SelectedIndex].kaydet();
        }

        private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < 10)
            {
                if (sekmeler[i] == false)
                {
                    string input = Interaction.InputBox("Yeni Html dosyasının adını giriniz.", "HTML DOSYASI", "");
                    myUserControl[i] = new UserControl1();
                    myUserControl[i].Dock = DockStyle.Fill;
                    TabPage myTabPage = new TabPage();
                    myTabPage.Text = input + ".html";
                    myTabPage.Controls.Add(myUserControl[i]);
                    tabControl1.TabPages.Add(myTabPage);
                    tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
                    sekmeler[i] = true;
                    i = 0;
                    break;
                }
                i++;
            }            
        }

        private void sekmeSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sekmeler[tabControl1.SelectedIndex] = false;
            tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
        }

        private void sekmelerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
           
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
           
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            myUserControl[0] = new UserControl1();
            tabControl1.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height - 100);
            userControl11.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);                      
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = tabControl1.TabPages.Count;
            myUserControl[i] = new UserControl1();
            myUserControl[i].Dock = DockStyle.Fill;
            TabPage myTabPage = new TabPage();
            myTabPage.Controls.Add(myUserControl[i]);
            tabControl1.TabPages.Add(myTabPage);
            tabControl1.SelectedIndex = i;
            sekmeler[i] = true;
            tabControl1.TabPages[i].Text = myUserControl[i].ac();
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myUserControl[tabControl1.SelectedIndex].Kes();
        }

        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myUserControl[tabControl1.SelectedIndex].geriAl();
        }

        private void yineleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myUserControl[tabControl1.SelectedIndex].ileriAl();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myUserControl[tabControl1.SelectedIndex].Kopyala();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myUserControl[tabControl1.SelectedIndex].Yapistir();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myUserControl[tabControl1.SelectedIndex].Sil();
        }

        private void bulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Aradığınız cümleyi girin:", "Aranan", "");
            myUserControl[tabControl1.SelectedIndex].FindMyText(input);
        }

        private void denemeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void userControl11_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
    }
}
