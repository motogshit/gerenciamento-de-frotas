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
using sistemasfrotas.Views.Relatorios;

namespace sistemasfrotas.Views.Relatorios
{
    public partial class FormEscolha : Form
    {
        private empresaController _controller = new empresaController();
        private string s;
        public FormEscolha(string alvo)
        {
            InitializeComponent();
            comboBox1.ValueMember = "CNPJ";
            comboBox1.DisplayMember = "Razao";
            comboBox1.DataSource = _controller.ListarTodos();
            s = alvo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new PaginaMestre(comboBox1.SelectedValue.ToString(), s).ShowDialog();
            this.Close();
        }
    }
}
