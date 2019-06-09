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
    public partial class JanelaAdd : Form
    {
        public string rbx;
        public FormMenu menu;
        public FormLogin login;
        public JanelaAdd(FormLogin login)
        {
            InitializeComponent();
            this.menu = login.menu;

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Conectando...", "Acesso Remoto");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
        }
        //salvar
        public void button2_Click(object sender, EventArgs e)
        {
            menu.listView2.SelectedItems[0].SubItems[1].Text = menu.janelaAdd.textNome.Text;
            menu.listView2.SelectedItems[0].SubItems[2].Text = menu.janelaAdd.textIpv4.Text;
            menu.listView2.SelectedItems[0].SubItems[3].Text = menu.janelaAdd.textPatrimonio.Text;
            menu.listView2.SelectedItems[0].SubItems[4].Text = menu.janelaAdd.textSala.Text;
            menu.listView2.SelectedItems[0].SubItems[5].Text = menu.janelaAdd.textDescricao.Text;
            Close();
        }
        private void textIpv4_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textDescricao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}