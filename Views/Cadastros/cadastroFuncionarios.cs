using System;
using System.Windows.Forms;
using sistemasfrotas.Model;
using sistemasfrotas.Controller;
using sistemasfrotas.Properties;

namespace sistemasfrotas.Views
{
    public partial class cadastroFuncionarios : Form
    {
        private string _state { get; set; }
        private int _id { get; set; }

        private funcionarioController _controller = new funcionarioController();
        private empresaController _empresa = new empresaController();
        private DateTime data;
        private Counter observer;

        public cadastroFuncionarios()
        {
            InitializeComponent();

            observer = new Counter();
            observer.RegisterObserver(FuncionariosView.Instance);
            observer.RegisterObserver(Estatisticas.Instance);

            cbEmpresa.ValueMember = "CNPJ";

                cbEmpresa.DisplayMember = "Razao";
                
                cbEmpresa.DataSource = _empresa.ListarTodos();
            
        }

        public cadastroFuncionarios(int id,string state)
        {
            InitializeComponent();
            observer = new Counter();
            observer.RegisterObserver(FuncionariosView.Instance);
            observer.RegisterObserver(Estatisticas.Instance);
            clear();
            _state = state;
            _id = id;
            editar(id);
        }

        private void editar(int id)
        {
            funcionarios dados;
            dados = _controller.BuscarPorId(id);
            
            txNome.Text = dados.Nome;
            txCargo.Text = dados.Cargo;
            txCPF.Text = dados.CPF;
            txCHN.Text = dados.CHN;
            txTelefone.Text = dados.Telefone;
            txRua.Text = dados.Rua;
            txBairro.Text = dados.Bairro;
            txCidade.Text = dados.Cidade;
            txEstado.Text = dados.Estado;
            txCasa.Text = dados.Numero_da_casa;
            txCracha.Text = dados.Numero_Cracha;
            cbEmpresa.ValueMember = "CNPJ";
            cbEmpresa.DisplayMember = "Razao";
            cbEmpresa.DataSource = _empresa.BuscarPorCNPJ(dados.CNPJ_Empresa);
            data = dados.Adicionado_em;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if(_state == "update")
            {
                _controller.AtualizarFuncionario(new funcionarios
                {
                    ID = _id,
                    Nome = txNome.Text.Trim(),
                    Cargo = txCargo.Text.Trim(),
                    CPF = txCPF.Text.Trim(),
                    CHN = txCHN.Text.Trim(),
                    Telefone = txTelefone.Text.Trim(),
                    Rua = txRua.Text.Trim(),
                    Bairro = txBairro.Text.Trim(),
                    Cidade = txCidade.Text.Trim(),
                    Estado = txEstado.Text.Trim(),
                    Numero_da_casa = txCasa.Text.Trim(),
                    Numero_Cracha = txCracha.Text.Trim(),
                    CNPJ_Empresa = cbEmpresa.SelectedValue.ToString(),
                    Adicionado_em = data
                });
                observer.Increment();
            }
            else
            {
                if(_controller.LocalizarCPF(txCPF.Text.Trim()) == null)
                {
                    _controller.Novo(new funcionarios
                    {
                        Nome = txNome.Text.Trim(),
                        Cargo = txCargo.Text.Trim(),
                        CPF = txCPF.Text.Trim(),
                        CHN = txCHN.Text.Trim(),
                        Telefone = txTelefone.Text.Trim(),
                        Rua = txRua.Text.Trim(),
                        Bairro = txBairro.Text.Trim(),
                        Cidade = txCidade.Text.Trim(),
                        Estado = txEstado.Text.Trim(),
                        Numero_da_casa = txCasa.Text.Trim(),
                        Numero_Cracha = txCracha.Text.Trim(),
                        CNPJ_Empresa = cbEmpresa.SelectedValue.ToString(),
                        Adicionado_em = DateTime.Now
                    });
                    observer.Increment();
                }
                else
                {
                    MessageBox.Show(Resources.CPFexiste);
                }
            }
        }

        void clear()
        {
            txNome.Text = txCargo.Text = txCPF.Text = txCHN.Text = txTelefone.Text = txRua.Text = txBairro.Text = txCidade.Text = txEstado.Text = txCasa.Text = txCracha.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
