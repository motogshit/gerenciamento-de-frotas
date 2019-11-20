
using sistemasfrotas.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemasfrotas.Views.Relatorios;

namespace sistemasfrotas.Views.Relatorios
{
    public partial class PaginaMestre : Form
    {
        private relatoriosController _controller = new relatoriosController();
        private string _s;
        private string _alvo;
        private DateTime d1 = new DateTime();
        private DateTime d2 = new DateTime();
        public PaginaMestre()
        {
            InitializeComponent();
        }
        public PaginaMestre(string cnpj, string alvo)
        {
            InitializeComponent();
            _s = cnpj;
            _alvo = alvo;
            if (alvo == "Funcionarios")
            {
                this.reportVeiculos.Visible = false;
                this.reportRecibos.Visible = false;
                this.reportAlugados.Visible = false;
                this.reportManutencao.Visible = false;
            }
            else if (alvo == "Veiculos")
            {
                this.reportFuncionarios.Visible = false;
                this.reportRecibos.Visible = false;
                this.reportAlugados.Visible = false;
                this.reportManutencao.Visible = false;

            }
            else if (alvo == "Recibos")
            {
                this.reportFuncionarios.Visible = false;
                this.reportVeiculos.Visible = false;
                this.reportAlugados.Visible = false;
                this.reportManutencao.Visible = false;
            }
            else if (alvo == "Alugados")
            {
                this.reportFuncionarios.Visible = false;
                this.reportVeiculos.Visible = false;
                this.reportRecibos.Visible = false;
                this.reportManutencao.Visible = false;
            }else if(alvo == "Manutencao")
            {
                this.reportFuncionarios.Visible = false;
                this.reportVeiculos.Visible = false;
                this.reportRecibos.Visible = false;
                this.reportAlugados.Visible = false;
            }
        }

        private void PaginaMestre_Load(object sender, EventArgs e)
        {
            dt1_ValueChanged(sender, e);
            this.reportManutencao.RefreshReport();
        }

        private void dt1_ValueChanged(object sender, EventArgs e)
        {
            if(_alvo == "Funcionarios")
            {
                try
                {
                    d1 = DateTime.Parse(dt1.Value.ToShortDateString());
                    d2 = DateTime.Parse(dt2.Value.ToShortDateString());
                    funcionariosBindingSource.DataSource = _controller.ListarFuncionariosPorEmpresa(_s, d1, d2);
                }
                catch (System.NotSupportedException ex)
                {

                }
                this.reportFuncionarios.RefreshReport();
            }else if(_alvo == "Veiculos")
            {
                try
                {
                    d1 = DateTime.Parse(dt1.Value.ToShortDateString());
                    d2 = DateTime.Parse(dt2.Value.ToShortDateString());
                    veiculosBindingSource.DataSource = _controller.ListarVeiculosPorEmpresa(_s, d1, d2);
                }
                catch(System.NotSupportedException ex)
                {

                }
                this.reportVeiculos.RefreshReport();
            }else if(_alvo == "Recibos")
            {
                try
                {
                    d1 = DateTime.Parse(dt1.Value.ToShortDateString());
                    d2 = DateTime.Parse(dt2.Value.ToShortDateString());
                    recibosBindingSource.DataSource = _controller.ListarRecibosPorEmpresa(_s, d1, d2);
                }
                catch (System.NotSupportedException ex)
                {

                }
                this.reportRecibos.RefreshReport();
            }else if(_alvo == "Alugados")
            {
                try
                {
                    d1 = DateTime.Parse(dt1.Value.ToShortDateString());
                    d2 = DateTime.Parse(dt2.Value.ToShortDateString());
                    alugadosBindingSource.DataSource = _controller.ListarAlugadosPorEmpresa(_s, d1, d2);
                }
                catch (System.NotSupportedException ex)
                {

                }
                this.reportAlugados.RefreshReport();
            }else if(_alvo == "Manutencao")
            {
                try
                {
                    d1 = DateTime.Parse(dt1.Value.ToShortDateString());
                    d2 = DateTime.Parse(dt2.Value.ToShortDateString());
                    manutencaoBindingSource.DataSource = _controller.ListarManutencaoPorEmpresa(_s, d1, d2);
                }
                catch (System.NotSupportedException ex)
                {

                }
                this.reportManutencao.RefreshReport();
            }
        }
    }
}
