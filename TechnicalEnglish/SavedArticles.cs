using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechEng_0._2
{
    public partial class SavedArticles : Form
    {
        public SavedArticles()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SavedArticles.ActiveForm.Hide();
            MainMenu MyForm2 = new MainMenu();
            MyForm2.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SavedArticles.ActiveForm.Hide();
            Dictionary MyForm3 = new Dictionary();
            MyForm3.ShowDialog();
            Close();
        }

        #region
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){}
        private void panel1_Paint(object sender, PaintEventArgs e){}
        #endregion
    }
}
