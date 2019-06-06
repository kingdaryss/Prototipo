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
    public partial class FormMenu : Form
    {
        int id = 0;
        public FormLogin login;
        public FormMenu menu;
        public JanelaAdd janelaAdd;

        public FormMenu(FormLogin login)
        {
            InitializeComponent();
            this.login = login;
        }


        //Gerenciar Chamado
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    
        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = listView1.SelectedIndices.Count - 1; i >= 0; i --)
            {
                listView1.Items.RemoveAt(listView1.SelectedIndices[i]);
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (listView2.Items.Count <= 0)
            {
                MessageBox.Show("Selecione um Item", "Item não selecionado");
            }
            else
            {
                string item = listView1.SelectedItems.ToString();
                MessageBox.Show(item, "Descrição");
            }
        }
        //Manter computadores
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
        }

        public void button8_Click(object sender, EventArgs e)
        {
            addItem();
        }
        public void addItem()
        {
            id++;
            ListViewItem item = new ListViewItem(new[] { id.ToString(), "PC 811", "192.168.1.1", "HE-2D-21-SA-32", "Sala 302", "Manutenção na data 31/06/2019" });
            listView2.Items.Add(item);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            for (int i = listView2.SelectedIndices.Count - 1; i >= 0; i--)
            {
                listView2.Items.RemoveAt(listView2.SelectedIndices[i]);
            }
        }
        //Instalar em redes
        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        //Sair
        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            login.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void listView2_ItemActivate(object sender, EventArgs e)
        {
            JanelaAdd janelaAdd = new JanelaAdd(login);
            this.janelaAdd = janelaAdd;
            janelaAdd.Visible = true;
            janelaAdd.textNome.Text = listView2.SelectedItems[0].SubItems[1].Text;
            janelaAdd.textIpv4.Text = listView2.SelectedItems[0].SubItems[2].Text;
            janelaAdd.textPatrimonio.Text = listView2.SelectedItems[0].SubItems[3].Text;
            janelaAdd.textSala.Text = listView2.SelectedItems[0].SubItems[4].Text;
            janelaAdd.textDescricao.Text = listView2.SelectedItems[0].SubItems[5].Text;
        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            login.fechar();
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            LerListView1 detalhes = new LerListView1(login);
            detalhes.Visible = true;
            detalhes.txtMatricula.Text = listView1.SelectedItems[0].SubItems[0].Text;
            detalhes.txtDescricao.Text = listView1.SelectedItems[0].SubItems[1].Text;
            detalhes.txtPatrimonio.Text = listView1.SelectedItems[0].SubItems[2].Text;
            detalhes.txtSala.Text = listView1.SelectedItems[0].SubItems[3].Text;
        }

        private void FormMenu_Activated(object sender, EventArgs e)
        {
            label4.Text = login.textUsername.Text;
        }
    }
}
