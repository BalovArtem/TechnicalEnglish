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
    public partial class MyAccount : Form
    {
        public MyAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyAccount.ActiveForm.Hide();
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MyAccount.ActiveForm.Hide();
            MainMenu MyForm2 = new MainMenu();
            MyForm2.ShowDialog();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyAccount.ActiveForm.Hide();
            Dictionary MyForm3 = new Dictionary();
            MyForm3.ShowDialog();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MyAccount.ActiveForm.Hide();
            SavedArticles MyForm4 = new SavedArticles();
            MyForm4.ShowDialog();
            Close();
        }
    }
}
