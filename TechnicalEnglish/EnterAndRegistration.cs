using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechEng_0._2
{
    public partial class Form6 : Form
    {
        private Users users;
        private string fileName;

        public Form6()
        {
            InitializeComponent();

            var fileDir = AppDomain.CurrentDomain.BaseDirectory;

            fileName = Path.Combine(fileDir, "users.bin");

            if (File.Exists(fileName))
                using (var fs = File.OpenRead(fileName))
                    users = (Users)new BinaryFormatter().Deserialize(fs);
            else
                users = new Users();
        }

        private void Form6_Load(object sender, EventArgs e){}
        public static bool IsWordLetter(char chr)
        {
            return char.IsLetter(chr);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Ошибка\nВведите логин");
            }
            else
            if (textBox2.Text == "")
            {
                MessageBox.Show("Ошибка\nВведите пароль");
            }
            else
            if (textBox1.Text.Length < 5)
            {
                MessageBox.Show("Ошибка\nЛогин должен иметь длину больше 5 символов");
            }
            else
            if (textBox2.Text.Length < 5)
            {
                MessageBox.Show("Ошибка\nПароль должен иметь длину больше 5 символов");
            }

            else
            {
                try
                {
                    if (checkBox1.Checked)
                    {
                        users.SignupNewUser(textBox1.Text, textBox2.Text);
                        using (var fs = File.OpenWrite(fileName))
                            new BinaryFormatter().Serialize(fs, users);
                    }
                    else
                    {
                        users.SignIn(textBox1.Text, textBox2.Text);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                Form6.ActiveForm.Hide();
                Form2 MyForm2 = new Form2();
                MyForm2.ShowDialog();
                Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e){}

        private void textBox2_TextChanged(object sender, EventArgs e) {}

        private void label1_Click(object sender, EventArgs e) {}

        [Serializable]
        class User
        {
            public string Login;
            public int PasswordHash;

            public User(string login, string password)
            {
                Login = login;
                PasswordHash = password.GetHashCode();
            }
        }

        [Serializable]
        class Users : List<User>
        {
            public bool SignIn(string login, string password)
            {
                var user = this.FirstOrDefault(u => u.Login == login);
                if (user == null)
                    MessageBox.Show("Неизвестный логин");

                if (user.PasswordHash != password.GetHashCode())
                    MessageBox.Show("Неизвестный пароль");

                return true;
            }

            public void SignupNewUser(string login, string password)
            {
                if (this.Any(u => u.Login == login))
                    MessageBox.Show("Пользователь с таким именем уже существует");

                Add(new User(login, password));
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) { }

        private void textBox1_TextChanged_1(object sender, EventArgs e) { }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e) { }
    }
}
