using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemasfrotas.Model;
using sistemasfrotas.Controller;

namespace sistemasfrotas.Views
{
    public partial class Login : Form
    {
        private systemDB db = new systemDB();
        public Login()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            logins dados = db.logins.AsNoTracking().FirstOrDefault(x => x.User == txUser.Text && x.Password == txPw.Text);

            if (dados == null)
            {
                MessageBox.Show("Usuario ou senhas incorretos","Falha ao realizar login",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                Sessao.NivelAcesso = dados.AcessLevel;
                Sessao.Usuario = dados.User;
                Sessao.Senha = dados.Password;
                new Dashboard().Show();
                Hide();
            }
        }
    }
}
