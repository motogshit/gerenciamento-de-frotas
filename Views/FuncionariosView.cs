using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemasfrotas.Controller;
using sistemasfrotas.Views.Relatorios;
using sistemasfrotas.Model;
using System.Globalization;

namespace sistemasfrotas.Views
{
    public partial class FuncionariosView : UserControl, IObserver
    {
        private static FuncionariosView _instance;

        private empresaController _empresa = new empresaController();

        private funcionarioController _controller = new funcionarioController();
        private exclusaoController exc = new exclusaoController();
        private Counter observer;

        public static FuncionariosView Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FuncionariosView();
                    return _instance;
                }
                else
                {
                    return _instance;
                }
            }
        }
        public FuncionariosView()
        {
            InitializeComponent();
            observer = new Counter();
            observer.RegisterObserver(VeiculosView.Instance);
            observer.RegisterObserver(this);
            observer.RegisterObserver(FinanceiroView.Instance);
            observer.RegisterObserver(Estatisticas.Instance);
            popularBox();
            PopularGrid();
        }
        void PopularGrid()
        {
                
                if (checkBox1.CheckState == CheckState.Checked)
                {
                    dataGridView1.DataSource = _controller.ListarTodos();
                }
                else
                {
                    try
                    {
                        dataGridView1.DataSource = _controller.ObterPorEmpresa(comboBox1.SelectedValue.ToString());
                    }
                    catch(System.NullReferenceException ex)
                    {
                        dataGridView1.DataSource = null;
                        comboBox1.Text = "";
                    }
                }
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentRow.Index != -1)
            {
                cadastroFuncionarios form = new cadastroFuncionarios(Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value), "update");

                if(form.ShowDialog() == DialogResult.OK)
                {
                    PopularGrid();
                }
                else
                {
                    PopularGrid(); 
                }
            }
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            cadastroFuncionarios form = new cadastroFuncionarios();
            if (form.ShowDialog() == DialogResult.OK)
            {
                PopularGrid();
            }
            else
            {
                PopularGrid();
            }

        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja remover esse funcionario?", "Aviso de remoção de registro",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (new Confirmacao().ShowDialog() == DialogResult.OK)
                {
                    if (dataGridView1.CurrentRow.Index != -1)
                    {
                        exc.ExcluirFuncionario(new funcionarios { 
                            ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value, new CultureInfo("pt-BR"))
                        });
                        observer.Increment();
                        
                    }
                }
            }
        }

        void popularBox()
        {
            comboBox1.ValueMember = "CNPJ";

            comboBox1.DisplayMember = "Razao";

            comboBox1.DataSource = _empresa.ListarTodos();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                comboBox1.Enabled = false;
                PopularGrid();
            }
            else
            {
                comboBox1.Enabled = true;

                PopularGrid();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void btRelatorio_Click(object sender, EventArgs e)
        {
            new FormEscolha("Funcionarios").Show();
        }

        public void Update(int count)
        {
            if(count > 0)
            {
                popularBox();
                PopularGrid();
            }
        }
    }
}

