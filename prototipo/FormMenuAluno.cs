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
    public partial class FormMenuAluno : Form
    {
        FormLogin login;
        FormMenu menu;
        public FormMenuAluno(FormLogin login)
        {
            InitializeComponent();
            this.login = login;
            this.menu = login.menu;
            verifyEnabledButton();
        }

        private void FormMenuAluno_FormClosing(object sender, FormClosingEventArgs e)
        {
            login.fechar();
        }

        private void FormMenuAluno_Activated(object sender, EventArgs e)
        {
            label1.Text = login.textUsername.Text;
        }


        private void button1_Click(object sender, EventArgs e)
        {
                ListViewItem item = new ListViewItem(new[] { label1.Text, txtDescricao.Text, txtPatrimonio.Text, txtSala.Text });
                menu.listView1.Items.Add(item);
                txtDescricao.Clear();
                txtPatrimonio.Clear();
                txtSala.Clear();
                MessageBox.Show("Já estamos analisando seu problema, aguarde!", "Problema enviado");
                this.Hide();
                login.Show();
        }

        private void txtPatrimonio_TextChanged(object sender, EventArgs e)
        {
            verifyEnabledButton();
        }

        private void txtSala_TextChanged(object sender, EventArgs e)
        {
            verifyEnabledButton();
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            verifyEnabledButton();
        }
        private void verifyEnabledButton()
        {
            if (!(String.IsNullOrEmpty(txtDescricao.Text)) && !(String.IsNullOrEmpty(txtPatrimonio.Text)) && !(String.IsNullOrEmpty(txtSala.Text)))
            {
                button1.Enabled = true;
            }
            else
                button1.Enabled = false;
        }
    }
}
