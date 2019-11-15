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

namespace sistemasfrotas.Views
{
    public partial class FuncionariosView : UserControl
    {
        private static FuncionariosView _instance;

        private empresaController _empresa = new empresaController();

        private funcionarioController _controller = new funcionarioController();

        private List<empresas> old = new List<empresas>();
        private List<empresas> novo = new List<empresas>();

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
                if(dataGridView1.CurrentRow.Index != -1)
                {
                    _controller.RemoverFuncionario(Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value));
                    MessageBox.Show("Removido com sucesso!", "Aviso de remoção de registro", MessageBoxButtons.OK);
                    PopularGrid();
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

        private void cbUpdater_Tick(object sender, EventArgs e)
        {
            

            novo = _empresa.ListarTodos();

            if (old.Count() == novo.Count())
            {

            }
            else
            {
                old = novo;
                popularBox();
            }
        }
    }
}

