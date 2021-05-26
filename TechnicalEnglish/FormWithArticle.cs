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
using DarrenLee.Translator;

namespace TechEng_0._2
{
    public partial class Form7 : Form
    {
        public Form7(string articleName)
        {
            InitializeComponent();
            label1.Text = File.ReadAllText(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(), articleName));
        }

        private void Form7_Load(object sender, EventArgs e){}
        private void label1_Click(object sender, EventArgs e){}
        private void richTextBox1_TextChanged(object sender, EventArgs e) { }

        public void Translate(object sender, EventArgs e)
        {
            label2.Text = Translator.Translate(richTextBox1.Text, "en", "ru");
        }
    }
}
