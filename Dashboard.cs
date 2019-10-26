using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemasfrotas.Views;

namespace sistemasfrotas
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            
            if (!Container.Controls.Contains(EmpresaView.Instance))
            {
                Container.Controls.Add(EmpresaView.Instance);
                EmpresaView.Instance.Dock = DockStyle.Fill;
                EmpresaView.Instance.BringToFront();
            }
            else
            {
                EmpresaView.Instance.BringToFront();
            }

            cadastroFuncionarios form = new cadastroFuncionarios();
            form.Show();
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            if (!Container.Controls.Contains(EmpresaView.Instance))
            {
                Container.Controls.Add(EmpresaView.Instance);
                EmpresaView.Instance.Dock = DockStyle.Fill;
                EmpresaView.Instance.BringToFront();
            }
            else
            {
                EmpresaView.Instance.BringToFront();
            }
        }

        private void btnVeiculos_Click(object sender, EventArgs e)
        {
            if (!Container.Controls.Contains(VeiculosView.Instance))
            {
                Container.Controls.Add(VeiculosView.Instance);
                VeiculosView.Instance.Dock = DockStyle.Fill;
                VeiculosView.Instance.BringToFront();
            }
            else
            {
                VeiculosView.Instance.BringToFront();
            }
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            if (!Container.Controls.Contains(FuncionariosView.Instance))
            {
                Container.Controls.Add(FuncionariosView.Instance);
                FuncionariosView.Instance.Dock = DockStyle.Fill;
                FuncionariosView.Instance.BringToFront();
            }
            else
            {
                FuncionariosView.Instance.BringToFront();
            }
        }
    }
}
