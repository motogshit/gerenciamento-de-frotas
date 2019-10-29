using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        veiculos vc = new veiculos();

        systemDB db = new systemDB();

        public VeiculosView()
        {
            InitializeComponent();
            PopularGrid(vc);
            popularBox();
        }

        void PopularGrid(veiculos v)
        {
            using(systemDB updater = new systemDB())
            {
                if(checkBox1.CheckState == CheckState.Checked)
                {
                    dataGridView1.DataSource = updater.veiculos.ToList();
                }
                else
                {
                    dataGridView1.DataSource = updater.veiculos.Where(x => x.cnpj == v.cnpj).ToList();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (dataGridView1.CurrentRow.Index != -1)
            {
                vc.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);

                cadastroVeiculos form = new cadastroVeiculos(vc, "update");

                if (form.ShowDialog() == DialogResult.OK)
                {
                    PopularGrid(vc);
                }
                else
                {
                    PopularGrid(vc);
                }
            }
        }

        private void btCadastra_Click(object sender, EventArgs e)
        {
            cadastroVeiculos form = new cadastroVeiculos();
            if(form.ShowDialog() == DialogResult.OK)
            {
                PopularGrid(vc);
            }
            else
            {
                PopularGrid(vc);
            }

        }

        private void setter(Object sender, EventArgs e)
        {
            if(checkBox1.CheckState == CheckState.Checked)
            {
                cbEmpresas.Enabled = false;
                vc.cnpj = "";
                PopularGrid(vc);
            }
            else
            {
                cbEmpresas.Enabled = true;
                vc.cnpj = cbEmpresas.SelectedValue.ToString();
                PopularGrid(vc);
            }
        }

        void popularBox()
        {
            cbEmpresas.ValueMember = "CNPJ";

            cbEmpresas.DisplayMember = "Razao";

            cbEmpresas.DataSource = db.empresas.ToList();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            setter(sender, e);
        }
    }
}
