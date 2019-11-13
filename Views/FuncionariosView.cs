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

namespace sistemasfrotas.Views
{
    public partial class FuncionariosView : UserControl
    {
        private static FuncionariosView _instance;

        private empresaController _empresa = new empresaController();

        private funcionarioController _controller = new funcionarioController();

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
            PopularGrid(comboBox1.SelectedValue.ToString());
        }
        void PopularGrid(string s)
        {
            /* Motivo para ter uma instancia de conexão isolada para a atualização do DataGrid...
               Por algum motivo após atualizar uma informação na tabela o comando db.funcionarios.ToList() não estava me retornando uma tabela atualizada
               por este motivo existe uma conexão isolada em todos os métodos popularGrid*/

                funcionarioController updater = new funcionarioController();
                if (checkBox1.CheckState == CheckState.Checked)
                {
                    dataGridView1.DataSource = updater.ListarTodos();
                }
                else
                {
                dataGridView1.DataSource = updater.ObterPorEmpresa(comboBox1.SelectedValue.ToString());
                }
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentRow.Index != -1)
            {
                cadastroFuncionarios form = new cadastroFuncionarios(Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value), "update");

                if(form.ShowDialog() == DialogResult.OK)
                {
                    PopularGrid(comboBox1.SelectedValue.ToString());
                }
                else
                {
                    PopularGrid(comboBox1.SelectedValue.ToString()); 
                }
            }
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            cadastroFuncionarios form = new cadastroFuncionarios();
            if (form.ShowDialog() == DialogResult.OK)
            {
                PopularGrid(comboBox1.SelectedValue.ToString());
            }
            else
            {
                PopularGrid(comboBox1.SelectedValue.ToString());
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
                    PopularGrid(comboBox1.SelectedValue.ToString());
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
                PopularGrid("");
            }
            else
            {
                comboBox1.Enabled = true;

                PopularGrid(comboBox1.SelectedValue.ToString());
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
    }
}

