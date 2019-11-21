using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemasfrotas.Controller;

namespace sistemasfrotas.Views
{
    public partial class Confirmacao : Form
    {
        public Confirmacao()
        {
            InitializeComponent();
        }

        private void btConfirma_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == Sessao.Senha)
            {
                if(Sessao.NivelAcesso >= 3)
                {
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Você não possui um nivel de acesso para executar essa acão","Erro ao executar operação",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Cancel;
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Sua senha está incorreta, digite a senha do usuario da sessão ativa", "Erro ao executar operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                Close();
            }
        }
    }
}
