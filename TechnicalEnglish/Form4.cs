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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4.ActiveForm.Hide();
            Form2 MyForm2 = new Form2();
            MyForm2.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4.ActiveForm.Hide();
            Form3 MyForm3 = new Form3();
            MyForm3.ShowDialog();
            Close();
        }

        #region
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){}
        private void panel1_Paint(object sender, PaintEventArgs e){}
        #endregion
    }
}
