using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemasfrotas.Controller;
using sistemasfrotas.Views;

namespace sistemasfrotas
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            //Carrega o nome do usuario na label
            lbUsuario.Text = "Usuário: " + Sessao.Usuario;
            //Verifica o nivel de acesso para Exibir na Label
            if(Sessao.NivelAcesso == 1)
            {
                //Nivel basico não pode remover informações
                lbAcesso.Text = "Nivel de acesso: Básico";
            }else if(Sessao.NivelAcesso == 2)
            {
                //Nivel Intermediario não pode remover informações
                lbAcesso.Text = "Nivel de acesso: Intermediario";
            }else if(Sessao.NivelAcesso == 3)
            {
                //Nivel Administrador(Gerenciador do sistema) pode remover informações(ACESSO TOTAL)
                lbAcesso.Text = "Nivel de acesso: Gerenciador do Sistema";
            }
            
            if (!Container1.Controls.Contains(EmpresaView.Instance))
            {
                Container1.Controls.Add(EmpresaView.Instance);
                EmpresaView.Instance.Dock = DockStyle.Fill;
                EmpresaView.Instance.BringToFront();
            }
            else
            {
                EmpresaView.Instance.BringToFront();
            }
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            if (!Container1.Controls.Contains(EmpresaView.Instance))
            {
                Container1.Controls.Add(EmpresaView.Instance);
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
            if (!Container1.Controls.Contains(VeiculosView.Instance))
            {
                Container1.Controls.Add(VeiculosView.Instance);
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
            if (!Container1.Controls.Contains(FuncionariosView.Instance))
            {
                Container1.Controls.Add(FuncionariosView.Instance);
                FuncionariosView.Instance.Dock = DockStyle.Fill;
                FuncionariosView.Instance.BringToFront();
            }
            else
            {
                FuncionariosView.Instance.BringToFront();
            }
        }

        private void relogio_Tick(object sender, EventArgs e)
        {

            lbhora.Text = DateTime.Now.ToLongTimeString();
            lbdata.Text = DateTime.Now.ToLongDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Container1.Controls.Contains(Estatisticas.Instance))
            {
                Container1.Controls.Add(Estatisticas.Instance);
                Estatisticas.Instance.Dock = DockStyle.Fill;
                Estatisticas.Instance.BringToFront();
            }
            else
            {
                Estatisticas.Instance.BringToFront();
            }
        }

        private void btnPagamentos_Click(object sender, EventArgs e)
        {
            if (!Container1.Controls.Contains(FinanceiroView.Instance))
            {
                Container1.Controls.Add(FinanceiroView.Instance);
                FinanceiroView.Instance.Dock = DockStyle.Fill;
                FinanceiroView.Instance.BringToFront();
            }
            else
            {
                FinanceiroView.Instance.BringToFront();
            }
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
