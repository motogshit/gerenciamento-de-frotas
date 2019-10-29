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

namespace sistemasfrotas.Views
{
    public partial class FuncionariosView : UserControl
    {
        private static FuncionariosView _instance;

        private systemDB db = new systemDB();

        private funcionarios empregados = new funcionarios();
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

            ////Personalização do DataGridView
            ////Personalização do DataGridView
            //dataGridView1.BorderStyle = BorderStyle.None;
            //dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            //dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            //dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            //dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            //dataGridView1.BackgroundColor = Color.White;

            //dataGridView1.EnableHeadersVisualStyles = false;
            //dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            //dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            //Gatilho para carregar informações no DataGridView
            PopularGrid(empregados);
            popularBox();

        }
        void PopularGrid(funcionarios f)
        {
            /* Motivo para ter uma instancia de conexão isolada para a atualização do DataGrid...
               Por algum motivo após atualizar uma informação na tabela o comando db.funcionarios.ToList() não estava me retornando uma tabela atualizada
               por este motivo existe uma conexão isolada em todos os métodos popularGrid*/
            using (systemDB updater = new systemDB())
            {
                if (checkBox1.CheckState == CheckState.Checked)
                {
                    dataGridView1.DataSource = updater.funcionarios.ToList();
                }
                else
                {
                    dataGridView1.DataSource = updater.funcionarios.Where(x => x.CNPJ_Empresa == f.CNPJ_Empresa).ToList();
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            funcionarios fun = new funcionarios();

            if(dataGridView1.CurrentRow.Index != -1)
            {
                fun.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);

                cadastroFuncionarios form = new cadastroFuncionarios(fun, "update");

                if(form.ShowDialog() == DialogResult.OK)
                {
                    PopularGrid(empregados);
                }
                else
                {
                    PopularGrid(empregados); 
                }
            }
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            cadastroFuncionarios form = new cadastroFuncionarios();
            if (form.ShowDialog() == DialogResult.OK)
            {
                PopularGrid(empregados);
            }
            else
            {
                PopularGrid(empregados);
            }

        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            funcionarios fun = new funcionarios();
            RemoverController rmv = new RemoverController();

            if (MessageBox.Show("Você deseja remover esse funcionario?", "Aviso de remoção de registro",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if(dataGridView1.CurrentRow.Index != -1)
                {
                    fun.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
                    MessageBox.Show(rmv.removerFuncionario(fun), "Aviso de remoção de registro", MessageBoxButtons.OK);
                    PopularGrid(empregados);
                }
            }
        }

        void popularBox()
        {
            comboBox1.ValueMember = "CNPJ";

            comboBox1.DisplayMember = "Razao";
            
            comboBox1.DataSource = db.empresas.ToList();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                comboBox1.Enabled = false;
                empregados.CNPJ_Empresa = "";
                PopularGrid(empregados);
            }
            else
            {
                comboBox1.Enabled = true;
                empregados.CNPJ_Empresa = comboBox1.SelectedValue.ToString();
                PopularGrid(empregados);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }
    }
}
