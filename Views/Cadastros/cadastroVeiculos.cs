using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemasfrotas.Model;
using sistemasfrotas.Controller;

namespace sistemasfrotas.Views
{
    public partial class cadastroVeiculos : Form
    {
        private string _state { get; set; }
        private int _id { get; set; }

        private empresaController _empresa = new empresaController();
        private veiculosController _controller = new veiculosController();
        private funcionarioController _funcionario = new funcionarioController();

        public cadastroVeiculos()
        {
            InitializeComponent();

            cbEmpresas.ValueMember = "CNPJ";
            cbEmpresas.DisplayMember = "Razao";
            cbEmpresas.DataSource = _empresa.ListarTodos();

            lbStatus.Visible = false;
            date.Visible = false;
        }

        public cadastroVeiculos(int id, string s)
        {
            InitializeComponent();
            _state = s;
            _id = id;
            editar(id);
            lbStatus.Visible = true;
            date.Visible = true;
        }

        private void editar(int id)
        {
            veiculos dados;
            dados = _controller.ObterPorId(id);

            txModelo.Text = dados.Modelo;
            txMarca.Text = dados.Marca;
            txAno.Text = dados.Ano;
            txPlaca.Text = dados.Placa_Veiculo;
            txChassi.Text = dados.Numero_chassi;
            txKm.Text = dados.Km_Inicial;
            lbStatus.Text = dados.Status;
            date.Text = Convert.ToString(dados.Adicionado_em);
            cbEmpresas.ValueMember = "CNPJ";
            cbEmpresas.DisplayMember = "Razao";
            cbEmpresas.DataSource = _empresa.BuscarPorCNPJ(dados.cnpj);

        }
        private void btSalvar_Click(object sender, EventArgs e)
        {
            if(_state == "update")
            {
                empresas razao;
                razao = _empresa.ObjetoCNPJ(cbEmpresas.SelectedValue.ToString());
                _controller.Atualizar(new veiculos
                {
                    ID=_id,
                    Modelo = txModelo.Text.Trim(),
                    Marca = txMarca.Text.Trim(),
                    Ano = txAno.Text.Trim(),
                    Placa_Veiculo = txPlaca.Text.Trim(),
                    Numero_chassi = txChassi.Text.Trim(),
                    Km_Inicial = txKm.Text.Trim(),
                    Km_Atual = txKm.Text.Trim(),
                    empresa = razao.Razao,
                    cnpj = cbEmpresas.SelectedValue.ToString().Trim(),
                    Status = "Disponivel",
                    Adicionado_em = Convert.ToDateTime(date.Text)
                });;
            }
            else
            {
                empresas razao;
                razao = _empresa.ObjetoCNPJ(cbEmpresas.SelectedValue.ToString());

                _controller.Adicionar(new veiculos
                {
                    Modelo = txModelo.Text.Trim(),
                    Marca = txMarca.Text.Trim(),
                    Ano = txAno.Text.Trim(),
                    Placa_Veiculo = txPlaca.Text.Trim(),
                    Numero_chassi = txChassi.Text.Trim(),
                    Km_Inicial = txKm.Text.Trim(),
                    Km_Atual = txKm.Text.Trim(),
                    empresa = razao.Razao,
                    cnpj = cbEmpresas.SelectedValue.ToString().Trim(),
                    Status = "Disponivel",
                    Adicionado_em = DateTime.Now,
                });
            }
            
        }

        void clear()
        {
            txModelo.Text = txMarca.Text = txAno.Text = txPlaca.Text = txKm.Text = txChassi.Text = "";
        }

        private void labelColor_Tick(object sender, EventArgs e)
        {
            if(lbStatus.Text == "Disponivel")
            {
                lbStatus.BackColor = Color.Lime; 
            }else if (lbStatus.Text == "Ocupado")
            {
                lbStatus.BackColor = Color.Yellow;
            }
            else
            {
                lbStatus.BackColor = Color.Crimson;
                lbStatus.ForeColor = Color.White;
            }
        }
    }
}
