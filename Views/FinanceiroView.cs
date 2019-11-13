using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemasfrotas.Views.Cadastros;
using sistemasfrotas.Views.Relatorios;
using sistemasfrotas.Controller;

namespace sistemasfrotas.Views
{
    public partial class FinanceiroView : UserControl
    {
        private recibosController _controller = new recibosController();
        private empresaController _empresa = new empresaController();
        private static FinanceiroView _instance;

        public static FinanceiroView Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FinanceiroView();
                    return _instance;
                }
                else
                {
                    return _instance;
                }
            }
        }
        public FinanceiroView()
        {
            InitializeComponent();
            popularBox();
            popularGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new reciboForm().ShowDialog();
            popularGrid();
            
        }

        void popularBox()
        {
            cbEmpresa.ValueMember = "CNPJ";

            cbEmpresa.DisplayMember = "Razao";

            cbEmpresa.DataSource = _empresa.ListarTodos();
        }

        void popularGrid()
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                dataGridView1.DataSource = _controller.ObterTodos();
            }
            else
            {
                dataGridView1.DataSource = _controller.ObterPorEmpresa(cbEmpresa.SelectedValue.ToString());
            }
        }

        private void cbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            popularGrid();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            popularGrid();
        }

        private void btRelatorio_Click(object sender, EventArgs e)
        {
            new FormEscolha("Recibos").Show();

        }
    }
}
