using System;
using System.Drawing;
using System.Windows.Forms;
using sistemasfrotas.Model;
using sistemasfrotas.Controller;
using sistemasfrotas.Properties;
using System.Globalization;

namespace sistemasfrotas.Views
{
    public partial class alugarVeiculo : Form
    {
        private string _state;
        private int _id;
        private int __id;

        private alugadosController _controller = new alugadosController();
        private funcionarioController _funcionario = new funcionarioController();
        private veiculosController _veiculos = new veiculosController();
        private Counter observer;

        private CultureInfo cultureInfo = new CultureInfo("pt-BR");
        public alugarVeiculo()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(676, 228);
            this.MaximumSize = new System.Drawing.Size(676, 228);
            this.MinimumSize = new System.Drawing.Size(676, 228);
            observer = new Counter();
            observer.RegisterObserver(VeiculosView.Instance);
            observer.RegisterObserver(Estatisticas.Instance);

        }
        public alugarVeiculo(int id, string s)
        {
            InitializeComponent();
            observer = new Counter();
            observer.RegisterObserver(VeiculosView.Instance);
            observer.RegisterObserver(Estatisticas.Instance);
            this.Size = new System.Drawing.Size(676, 319);
            this.MaximumSize = new System.Drawing.Size(676, 319);
            this.MinimumSize = new System.Drawing.Size(676, 319);
            _state = s;
            devolve(id);
            ocultar();
        }

        private void ocultar()
        {
            lbEnt.Visible = true;
            pnh.Visible = true;
            txKmEnt.Visible = true;
        }

        void devolve(int id)
        {
            alugados a = _controller.ObterPorCodigo(id);
            if(a == null)
            {
                if (MessageBox.Show("Este veiculo não está em uso") == DialogResult.OK)
                {
                    Close();
                }
            }
            else
            {
                __id = a.ID;
                txCodF.Text = a.Codigo_funcionario.ToString(cultureInfo);
                txCodV.Text = a.codigo_carro.ToString(cultureInfo);
                txNome.Text = a.Nome;
                txPlaca.Text = a.Placa_Veiculo;
                txKmIni.Text = a.Km_Inicial;
                txKmEnt.Text = a.Km_Entregue;
                lbStatus.Text = a.status;
                lbAlugado.Text = "Alugado em: " + Convert.ToString(a.Alugado_em, cultureInfo);
                lbDevolvido.Text = "Devolvido em: " + Convert.ToString(a.Devolvido_em, cultureInfo);
            }

        }
        private void txCodV_TextChanged(object sender, EventArgs e)
        {
            veiculos vei;
            if(!string.IsNullOrEmpty(txCodV.Text))
            {
                _id = Convert.ToInt32(txCodV.Text, cultureInfo);
                vei = _veiculos.ObterPorId(_id);
                if (vei == null)
                {
                    MessageBox.Show("Erro ao buscar veiculo", "Veiculo não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txPlaca.Text = vei.Placa_Veiculo;
                    txKmIni.Text = vei.Km_Atual;
                    lbStatus.Text = vei.Status.ToUpper(cultureInfo);
                }
            }
            
        }

        private void txCodF_TextChanged(object sender, EventArgs e)
        {
            funcionarios fun;
            
            if (!string.IsNullOrEmpty(txCodF.Text))
            {
                _id = Convert.ToInt32(txCodF.Text, cultureInfo);
                fun = _funcionario.BuscarPorId(_id);
                if (fun == null)
                {
                    MessageBox.Show(Resources.AvisoIDFuncionario, Resources.ErroProcurarFuncionario, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txNome.Text = fun.Nome;
                }
            }
            
        }

        private void btSave_Click(object sender, EventArgs e)
        {


            if (_state == "devolve")
            {
                alugados data;
                data = _controller.ObterPorId(__id);

                data.Devolvido_em = DateTime.Now;
                data.Km_Entregue = txKmEnt.Text.Trim();
                data.status = "Disponivel";
                _controller.Devolver(data);

                veiculos updater;
                updater = _veiculos.ObterPorId(data.codigo_carro);
                updater.Km_Atual = txKmEnt.Text.Trim();
                updater.Status = "Disponivel".Trim();
                _veiculos.Atualizar(updater);
                observer.Increment();
            }
            else
            {
                if (_controller.VerificarCarro(Convert.ToInt32(txCodV.Text, cultureInfo)) == null)
                {
                    if (_controller.VerificarFuncionario(Convert.ToInt32(txCodF.Text, cultureInfo)) == null)
                    {
                        funcionarios fun = new funcionarios();
                        fun = _funcionario.BuscarPorId(Convert.ToInt32(txCodF.Text, cultureInfo));
                        _controller.Alugar(new alugados
                        {
                            codigo_carro = Convert.ToInt32(txCodV.Text, cultureInfo),
                            Codigo_funcionario = Convert.ToInt32(txCodF.Text, cultureInfo),
                            Placa_Veiculo = txPlaca.Text.Trim(),
                            Nome = txNome.Text.Trim(),
                            Km_Inicial = txKmIni.Text.Trim(),
                            status = "Em Uso".Trim(),
                            cnpj = fun.CNPJ_Empresa,
                            Alugado_em = DateTime.Now
                        });
                        veiculos updater;
                        updater = _veiculos.ObterPorId(Convert.ToInt32(txCodV.Text,cultureInfo));
                        updater.Status = "Em Uso";
                        _veiculos.Atualizar(updater);
                        observer.Increment();
                    }
                    else
                    {
                        MessageBox.Show("Funcionario ja possui veiculo");
                    }

                }
                else
                {
                    MessageBox.Show("Veiculo em uso");
                }
               
            } 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(lbStatus.Text == "DISPONIVEL")
            {
                lbStatus.BackColor = Color.Lime;
            }
            else
            {
                lbStatus.BackColor = Color.Yellow;
                lbStatus.ForeColor = Color.Black;
            }
        }

        private void txCodV_KeyPress(object sender, KeyPressEventArgs e)
        {

            //aceita apenas números, tecla backspace.
            if(!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
