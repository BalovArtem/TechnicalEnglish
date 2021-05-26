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
    public partial class Form2 : Form
    {
        string ArticleName1 = "TextFile1.txt";
        string ArticleName2 = "TextFile2.txt";
        string ArticleName3 = "TextFile3.txt";
        string ArticleName4 = "TextFile4.txt";


        public Form2()
        {
            InitializeComponent();

            label1.Text = FindTxt(ArticleName1);
            label2.Text = FindTxt(ArticleName2);
            label3.Text = FindTxt(ArticleName3);
            label4.Text = FindTxt(ArticleName4);
        }

        private void Dictionary(object sender, EventArgs e)
        {
            Form2.ActiveForm.Hide();
            Form3 MyForm3 = new Form3();
            MyForm3.ShowDialog();
            Close();
        }

        private void Articles(object sender, EventArgs e)
        {
            Form2.ActiveForm.Hide();
            Form4 MyForm4 = new Form4();
            MyForm4.ShowDialog();
            Close();
        }

        private void MyAccount(object sender, EventArgs e)
        {
            Form2.ActiveForm.Hide();
            Form5 MyForm5 = new Form5();
            MyForm5.ShowDialog();
            Close();
        }

        private void label1_Click(object sender, EventArgs e){OpenArticle(ArticleName1);}
        private void label2_Click(object sender, EventArgs e){OpenArticle(ArticleName2);}
        private void label3_Click(object sender, EventArgs e){OpenArticle(ArticleName3);}
        private void label4_Click(object sender, EventArgs e){OpenArticle(ArticleName4);}

        public string FindTxt(string articleName)
        {
            string FoundedText = File.ReadAllText(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(), "Articles\\" + articleName));
            return FoundedText;
        }

        public void OpenArticle(string ChosenArticle)
        {
            Form7 MyForm7 = new Form7("Articles\\" + ChosenArticle);
            MyForm7.ShowDialog();
        }
    }   
}
