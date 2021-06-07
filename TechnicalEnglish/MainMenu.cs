using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechEng_0._2
{
    public partial class MainMenu : Form
    {
        string ArticleName1 = "TextFile1.txt";
        string ArticleName2 = "TextFile2.txt";
        string ArticleName3 = "TextFile3.txt";
        string ArticleName4 = "TextFile4.txt";


        public MainMenu()
        {
            InitializeComponent();

            label1.Text = FindText(ArticleName1);
            label2.Text = FindText(ArticleName2);
            label3.Text = FindText(ArticleName3);
            label4.Text = FindText(ArticleName4);
        }

        private void Dictionary(object sender, EventArgs e)
        {
            MainMenu.ActiveForm.Hide();
            Dictionary MyForm3 = new Dictionary();
            MyForm3.ShowDialog();
            Close();
        }

        private void Articles(object sender, EventArgs e)
        {
            MainMenu.ActiveForm.Hide();
            SavedArticles MyForm4 = new SavedArticles();
            MyForm4.ShowDialog();
            Close();
        }

        private void MyAccount(object sender, EventArgs e)
        {
            MainMenu.ActiveForm.Hide();
            MyAccount MyForm5 = new MyAccount();
            MyForm5.ShowDialog();
            Close();
        }

        public void OpenFormWithArtile(string articleName)
        {
            Article MyForm7 = new Article("Articles\\" + articleName);
            MyForm7.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e) { OpenFormWithArtile(ArticleName1); }
        private void label2_Click(object sender, EventArgs e) { OpenFormWithArtile(ArticleName2); }
        private void label3_Click(object sender, EventArgs e) { OpenFormWithArtile(ArticleName3); }
        private void label4_Click(object sender, EventArgs e) { OpenFormWithArtile(ArticleName4); }

        public string FindText(string articleName)
        {
            string Text = File.ReadAllText(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(), "Articles\\" + articleName));
            return Text;
        }
    }
}
