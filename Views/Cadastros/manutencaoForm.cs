using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemasfrotas.Controller;
using sistemasfrotas.Model;

namespace sistemasfrotas.Views.Cadastros
{
    public partial class manutencaoForm : Form
    {
        private manutencaoController _controller;
        private recibosController _recibo;
        private veiculosController _veiculos;
        private veiculos obj = new veiculos();
        private string _state;
        private int _id;
        private Counter observer;
        public manutencaoForm(string s , int ID)
        {
            InitializeComponent();
            _controller = new manutencaoController();
            _veiculos = new veiculosController();
            _recibo = new recibosController();
            observer = new Counter();
            observer.RegisterObserver(VeiculosView.Instance);
            observer.RegisterObserver(FinanceiroView.Instance);
            observer.RegisterObserver(Estatisticas.Instance);
            _state = s;
            obj = _veiculos.ObterPorId(ID);
            if(obj.Status == "Em Manutenção")
            {
                _id = obj.ID;
                _state = "devolve";
                LoadData();
            }
        }
        public void LoadData()
        {
            manutencao data = _controller.ObterPorID(obj.ID);
            txCusto.Text = data.Custo.ToString();
            label1.Text = "Custo real da manutenção";
            txDesc.Text = data.Descricao;
            label2.Text = "Problema real do automovel";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(_state == "devolve")
            {
                manutencao atualizar = new manutencao();
                atualizar = _controller.ObterPorID(_id);
                atualizar.Data_Devolvido = DateTime.Now;
                atualizar.Status = "Consertado";
                atualizar.Custo = Convert.ToDouble(txCusto.Text, new CultureInfo("pt-BR"));
                atualizar.Descricao = txDesc.Text.Trim();
                _controller.Devolver(atualizar);
                _controller.Salver();

                veiculos updater = _veiculos.ObterPorId(atualizar.CodigoCarro);
                updater.Status = "Disponivel";
                _veiculos.Atualizar(updater);

                recibos recibo = _recibo.ObterPorManutencao(atualizar.ID);
                recibo.Valor = Convert.ToDouble(txCusto.Text, new CultureInfo("pt-BR"));
                recibo.Descricao = txDesc.Text;
                recibo.data = DateTime.Now;
                _recibo.AtualizarReciboManutencao(recibo);
                _recibo.Salvar();

                observer.Increment();
                Close();
            }
            else
            {
                _controller.Adicionar(new manutencao
                {
                    CodigoCarro = obj.ID,
                    Modelo = obj.Modelo,
                    Marca = obj.Marca,
                    Ano = obj.Ano,
                    Placa_Veiculo = obj.Placa_Veiculo,
                    Km_Atual = obj.Km_Atual,
                    empresa = obj.empresa,
                    cnpj = obj.cnpj,
                    Status = "Em Manutenção",
                    Custo = Convert.ToDouble(txCusto.Text, new CultureInfo("pt-BR")),
                    Descricao = txDesc.Text.Trim(),
                    Data_Manutencao = DateTime.Now
                });
                _controller.Salver();

                veiculos updater = _veiculos.ObterPorId(obj.ID);
                updater.Status = "Em Manutenção";
                _veiculos.Atualizar(updater);

                manutencao codigo = _controller.ObterPorID(obj.ID);

                _recibo.AdicionarRecibo(new recibos
                {
                    CodigoManutencao = codigo.ID,
                    CNPJ = obj.cnpj,
                    Razao = obj.empresa,
                    Descricao = txDesc.Text,
                    Valor = Convert.ToDouble(txCusto.Text, new CultureInfo("pt-BR")),
                    data = DateTime.Now
                });
                _recibo.Salvar();

                observer.Increment();
                Close();
            }
        }

        private void txCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (txCusto.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
