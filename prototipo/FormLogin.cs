using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototipo
{
    public partial class FormLogin : Form
    {
        public FormMenu menu;
        public FormMenuAluno menuAluno;
        public FormLogin()
        {
            InitializeComponent();
            this.menu = new FormMenu(this);
            this.menuAluno = new FormMenuAluno(this);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            validLogin();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            closingLogin();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textPassword_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void validLogin()
        {

            if (textUsername.Text == "admin" && textPassword.Text == "admin")
            {
                this.menu.Show();
                this.Hide();
                textUsername.Clear();
                textPassword.Clear();
            }
            else if (textUsername.Text == "1910599" && textPassword.Text == "123456")
            {
                this.menuAluno.Show();
                this.Hide();
                textUsername.Clear();
                textPassword.Clear();
            }
            else if (textUsername.Text == "5555555" && textPassword.Text == "123456")
            {
                this.menuAluno.Show();
                this.Hide();
                textUsername.Clear();
                textPassword.Clear();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha inválido");
            }
        }
        public void closingLogin()
        {
            DialogResult result = MessageBox.Show("Deseja realmente fechar?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                fechar();
            }
        }
        public void fechar()
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Activated(object sender, EventArgs e)
        {
            textUsername.Focus();
        }
    }
}
