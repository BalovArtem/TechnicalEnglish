using DarrenLee.Translator;
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
    public partial class Dictionary : Form
    {
        string pathText = FindTxt("Words.txt");
        string pathTranslatedText = FindTxt("WordsTranslated.txt");

        public static string FindTxt(string TxtName)
        {
            string txt = Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(), "Dictionary\\" + TxtName);
            return txt;
        }

        public Dictionary()
        {
            InitializeComponent();

            richTextBox1.Text = File.ReadAllText(pathText);
            richTextBox2.Text = File.ReadAllText(pathTranslatedText);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dictionary.ActiveForm.Hide();
            MainMenu MyForm2 = new MainMenu();
            MyForm2.ShowDialog();
            Close();
        }

        private void AddWordToDictionary(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите слово");
            }
                else
            {
                string translatedText = Translator.Translate(textBox1.Text, "en", "ru");

                if (richTextBox1.Text == "")
                {
                    richTextBox1.Text = (textBox1.Text);
                    richTextBox2.Text = (translatedText);

                    File.AppendAllText(pathText, textBox1.Text + "\n");
                    File.AppendAllText(pathTranslatedText,richTextBox2.Text + "\n");

                    textBox1.Text = "";

                }
                else
                {
                    richTextBox1.Text = (richTextBox1.Text + "\n" + textBox1.Text);
                    richTextBox2.Text = (richTextBox2.Text + "\n" + translatedText);

                    File.AppendAllText(pathText, textBox1.Text + "\n");
                    File.AppendAllText(pathTranslatedText,translatedText + "\n");

                    textBox1.Text = "";


                }
            }
        }
        #region
        private void label4_Click(object sender, EventArgs e) { }
        private void Form3_Load(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e){}
        private void panel1_Paint(object sender, PaintEventArgs e){}
        private void richTextBox1_TextChanged(object sender, EventArgs e){}
        private void richTextBox2_TextChanged(object sender, EventArgs e){}
        #endregion
    }
}
