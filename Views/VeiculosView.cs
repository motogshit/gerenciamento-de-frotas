using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemasfrotas.Model;
using sistemasfrotas.Controller;
using System.Globalization;

namespace sistemasfrotas.Views
{
    public partial class VeiculosView : UserControl
    {
        private static VeiculosView _instance;

        public static VeiculosView Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new VeiculosView();
                    return _instance;
                }
                else
                {
                    return _instance;
                }
            }
        }

        private empresaController _empresa = new empresaController();

        public VeiculosView()
        {
            InitializeComponent();
            popularBox();
            PopularGrid(cbEmpresas.SelectedValue.ToString());
            
        }

        void PopularGrid(string s)
        {
            veiculosController __controller = new veiculosController();
                if(checkBox1.CheckState == CheckState.Checked)
                {
                    dataGridView1.DataSource = __controller.ListarTodos();
                }
                else
                {
                    dataGridView1.DataSource = __controller.ListarPorEmpresa(s);
                }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (dataGridView1.CurrentRow.Index != -1)
            {
                cadastroVeiculos form = new cadastroVeiculos(Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value,new CultureInfo("pt-BR")), "update");

                if (form.ShowDialog() == DialogResult.OK)
                {
                    PopularGrid(cbEmpresas.SelectedValue.ToString());
                    form.Dispose();
                }
                else
                {
                    PopularGrid(cbEmpresas.SelectedValue.ToString());
                    form.Dispose();
                }
            }
        }

        private void btCadastra_Click(object sender, EventArgs e)
        {
            cadastroVeiculos form = new cadastroVeiculos();
            if(form.ShowDialog() == DialogResult.OK)
            {
                PopularGrid(cbEmpresas.SelectedValue.ToString());
                form.Dispose();
            }
            else
            {
                PopularGrid(cbEmpresas.SelectedValue.ToString());
                form.Dispose();
            }

        }

        private void setter(Object sender, EventArgs e)
        {
            if(checkBox1.CheckState == CheckState.Checked)
            {
                cbEmpresas.Enabled = false;
                PopularGrid("");
            }
            else
            {
                cbEmpresas.Enabled = true;
                PopularGrid(cbEmpresas.SelectedValue.ToString());
            }
        }

        void popularBox()
        {
            cbEmpresas.ValueMember = "CNPJ";

            cbEmpresas.DisplayMember = "Razao";

            cbEmpresas.DataSource = _empresa.ListarTodos();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            setter(sender, e);
        }

        private void btAluga_Click(object sender, EventArgs e)
        {
            alugarVeiculo form = new alugarVeiculo();

            if(form.ShowDialog() == DialogResult.OK)
            {
                PopularGrid(cbEmpresas.SelectedValue.ToString());
                form.Dispose();
            }
            else
            {
                PopularGrid(cbEmpresas.SelectedValue.ToString());
                form.Dispose();
            }
        }

        private void btDevolve_Click(object sender, EventArgs e)
        {
            

            if (dataGridView1.CurrentRow.Index != -1)
            {
                alugarVeiculo form = new alugarVeiculo(Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value, new CultureInfo("pt-BR")), "devolve");
                if (form.ShowDialog() == DialogResult.OK)
                {
                    PopularGrid(cbEmpresas.SelectedValue.ToString());
                    form.Dispose();
                }
                else
                {
                    PopularGrid(cbEmpresas.SelectedValue.ToString());
                    form.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Selecione um veiculo com status em uso antes de devolver");
            }
            
        }
    }
}
