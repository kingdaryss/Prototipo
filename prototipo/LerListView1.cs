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
    public partial class LerListView1 : Form
    {
        FormMenu menu;
        FormLogin login;
        public LerListView1(FormLogin login)
        {
            InitializeComponent();
            this.login = login;
            this.menu = login.menu;
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
