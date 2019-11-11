using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemasfrotas.Model;
using sistemasfrotas.Controller;
namespace sistemasfrotas.Views.Cadastros
{
    public partial class reciboForm : Form
    {
        private recibosController _controller = new recibosController();
        public reciboForm()
        {
            InitializeComponent();
        }

        private void txFun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (txValor.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txFun_TextChanged(object sender, EventArgs e)
        {
            recibos valores = new recibos();

            valores = _controller.ObterDadosFuncionario(Convert.ToInt32(txFun.Text,new CultureInfo("pt-BR")));

            lbNome.Text = valores.Nome_Funcionario;
            lbEmpresa.Text = valores.Razao;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            recibos formulario = new recibos();

            formulario = _controller.ObterDadosFuncionario(Convert.ToInt32(txFun.Text,new CultureInfo("pt-BR")));
            formulario.Valor = Convert.ToDouble(txValor.Text.Trim(), new CultureInfo("pt-Br"));
            formulario.data = DateTime.Now;
            formulario.Descricao = txDesc.Text.Trim();

            _controller.AdicionarRecibo(formulario);
            _controller.Salvar();
        }
    }
}
