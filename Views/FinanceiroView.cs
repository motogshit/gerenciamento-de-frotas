using System;
using System.Collections.Generic;
using System.Windows.Forms;
using sistemasfrotas.Views.Cadastros;
using sistemasfrotas.Views.Relatorios;
using sistemasfrotas.Controller;
using sistemasfrotas.Model;
namespace sistemasfrotas.Views
{
    public partial class FinanceiroView : UserControl, IObserver
    {
        private recibosController _controller = new recibosController();
        private empresaController _empresa = new empresaController();
        private static FinanceiroView _instance;
        private Counter observer;
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
                try
                {
                    dataGridView1.DataSource = _controller.ObterPorEmpresa(cbEmpresa.SelectedValue.ToString());
                }catch(System.NullReferenceException ex)
                {
                    dataGridView1.DataSource = null;
                    cbEmpresa.Text = "";
                }
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

        public void Update(int count)
        {
            if(count > 0)
            {
                popularBox();
                popularGrid();
            }   
        }
    }
}
