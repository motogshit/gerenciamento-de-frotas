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
    public partial class alugarVeiculo : Form
    {
        private string _state;
        private int _id;
        private int __id;

        private alugadosController _controller = new alugadosController();
        private funcionarioController _funcionario = new funcionarioController();
        private veiculosController _veiculos = new veiculosController();
        public alugarVeiculo()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(676, 228);
            this.MaximumSize = new System.Drawing.Size(676, 228);
            this.MinimumSize = new System.Drawing.Size(676, 228);
            
        }
        public alugarVeiculo(int id, string s)
        {
            InitializeComponent();
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
            __id = a.ID;
            txCodF.Text = a.Codigo_funcionario.ToString();
            txCodV.Text = a.codigo_carro.ToString();
            txNome.Text = a.Nome;
            txPlaca.Text = a.Placa_Veiculo;
            txKmIni.Text = a.Km_Inicial;
            txKmEnt.Text = a.Km_Entregue;
            lbStatus.Text = a.status;
            lbAlugado.Text = "Alugado em: " + Convert.ToString(a.Alugado_em);
            lbDevolvido.Text = "Devolvido em: " + Convert.ToString(a.Devolvido_em);

        }
        private void txCodV_TextChanged(object sender, EventArgs e)
        {
            veiculos vei;
            _id = Convert.ToInt32(txCodV.Text);
            vei = _veiculos.ObterPorId(_id);
            if(vei == null)
            {
                MessageBox.Show("Veiculo não encontrado, verifique o codigo e tente novamente","Erro ao buscar veiculo", MessageBoxButtons.OK);
            }
            else
            {
                txPlaca.Text = vei.Placa_Veiculo;
                txKmIni.Text = vei.Km_Atual;
                lbStatus.Text = vei.Status.ToUpper();
            }
        }

        private void txCodF_TextChanged(object sender, EventArgs e)
        {
            funcionarios fun;
            _id = Convert.ToInt32(txCodF.Text);
            fun = _funcionario.BuscarPorId(_id);
            if (fun == null)
            {
                MessageBox.Show("Funcionario não encontrado, verifique o cidogo do funcionario e tente novamente", "Erro ao buscar funcionario", MessageBoxButtons.OK);
            }
            else
            {
                txNome.Text = fun.Nome;
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
            }
            else
            {
                if (_controller.VerificarCarro(Convert.ToInt32(txCodV.Text)) == null)
                {
                    if (_controller.VerificarFuncionario(Convert.ToInt32(txCodF.Text)) == null)
                    {
                        _controller.Alugar(new alugados
                        {
                            codigo_carro = Convert.ToInt32(txCodV.Text),
                            Codigo_funcionario = Convert.ToInt32(txCodF.Text),
                            Placa_Veiculo = txPlaca.Text.Trim(),
                            Nome = txNome.Text.Trim(),
                            Km_Inicial = txKmIni.Text.Trim(),
                            status = "Em Uso".Trim(),
                            Alugado_em = DateTime.Now
                        });
                        veiculos updater;
                        updater = _veiculos.ObterPorId(Convert.ToInt32(txCodV.Text));
                        updater.Status = "Em Uso";
                        _veiculos.Atualizar(updater);
                    }
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
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
