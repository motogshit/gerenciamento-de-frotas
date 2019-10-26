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

            //Personalização do DataGridView
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            //Gatilho para carregar informações no DataGridView
            PopularGrid();

        }
        void PopularGrid()
        {
            using(systemDB db = new systemDB())
            {
                dataGridView1.DataSource = db.funcionarios.ToList();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            funcionarios fun = new funcionarios();

            if(dataGridView1.CurrentRow.Index != -1)
            {
                fun.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);

                cadastroFuncionarios form = new cadastroFuncionarios(fun);

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
            form.Show();
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
                    PopularGrid();
                }
            }
        }
    }
}
