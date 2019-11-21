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
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace sistemasfrotas.Views
{
    public partial class CadastroEmpresa : Form
    {
        private string _state { get; set; }
        private int _id { get; set; }

        private empresaController _controller = new empresaController();

        public CadastroEmpresa()
        {
            InitializeComponent();
            clear();
        }
        
        public CadastroEmpresa(int id, string state)
        {
            InitializeComponent();
            clear();
            _state = state;
            _id = id;
            editar(id);
        }

        private void editar(int id)
        {
            empresas informaçoes;
            informaçoes = _controller.BuscarPorId(id);
            if (informaçoes.Filial == "Sim")
            {
                checkBox1.Checked = true;
            }

            txRazao.Text = informaçoes.Razao;
            txFantasia.Text = informaçoes.Fantasia;
            txCNPJ.Text = informaçoes.CNPJ;
            txTel1.Text = informaçoes.Telefone1;
            txTel2.Text = informaçoes.Telefone2;
            txEmail.Text = informaçoes.Email;
            txSite.Text = informaçoes.Website;
            txFilial.Text = informaçoes.Filial_Numero;
            txSede.Text = informaçoes.CNPJ_Sede;
            txRua.Text = informaçoes.Rua;
            txBairro.Text = informaçoes.Bairro;
            txCidade.Text = informaçoes.Cidade;
            txEstado.Text = informaçoes.Estado;
            txNumero.Text = informaçoes.Numero;
            txCEP.Text = informaçoes.CEP;

        }

        private void btSave_Click(object sender, EventArgs coco)
        {

            if(_state == "update")
            {

                if(checkBox1.CheckState == CheckState.Checked)
                {
                    _controller.AtualizarEmpresa(new empresas
                    {
                        ID = _id,
                        Razao = txRazao.Text.Trim(),
                        Fantasia = txFantasia.Text.Trim(),
                        CNPJ = txCNPJ.Text.Trim(),
                        Telefone1 = txTel1.Text.Trim(),
                        Telefone2 = txTel2.Text.Trim(),
                        Email = txEmail.Text.Trim(),
                        Website = txSite.Text.Trim(),
                        Filial_Numero = txFilial.Text.Trim(),
                        CNPJ_Sede = txSede.Text.Trim(),
                        Rua = txRua.Text.Trim(),
                        Bairro = txBairro.Text.Trim(),
                        Cidade = txCidade.Text.Trim(),
                        Estado = txEstado.Text.Trim(),
                        Numero = txNumero.Text.Trim(),
                        CEP = txCEP.Text.Trim(),
                        Filial = "Sim".Trim(),
                        Adicionado_em = DateTime.Now
                    });
                }
                else
                {
                    _controller.AtualizarEmpresa(new empresas
                    {
                        ID = _id,
                        Razao = txRazao.Text.Trim(),
                        Fantasia = txFantasia.Text.Trim(),
                        CNPJ = txCNPJ.Text.Trim(),
                        Telefone1 = txTel1.Text.Trim(),
                        Telefone2 = txTel2.Text.Trim(),
                        Email = txEmail.Text.Trim(),
                        Website = txSite.Text.Trim(),
                        Filial_Numero = txFilial.Text.Trim(),
                        CNPJ_Sede = txSede.Text.Trim(),
                        Rua = txRua.Text.Trim(),
                        Bairro = txBairro.Text.Trim(),
                        Cidade = txCidade.Text.Trim(),
                        Estado = txEstado.Text.Trim(),
                        Numero = txNumero.Text.Trim(),
                        CEP = txCEP.Text.Trim(),
                        Filial = "Não".Trim(),
                        Adicionado_em = DateTime.Now
                    });
                }
               
            }
            else
             {
                if (checkBox1.CheckState == CheckState.Checked)
                {
                    _controller.Novo(new empresas
                    {
                        Razao = txRazao.Text.Trim(),
                        Fantasia = txFantasia.Text.Trim(),
                        CNPJ = txCNPJ.Text.Trim(),
                        Telefone1 = txTel1.Text.Trim(),
                        Telefone2 = txTel2.Text.Trim(),
                        Email = txEmail.Text.Trim(),
                        Website = txSite.Text.Trim(),
                        Filial_Numero = txFilial.Text.Trim(),
                        CNPJ_Sede = txSede.Text.Trim(),
                        Rua = txRua.Text.Trim(),
                        Bairro = txBairro.Text.Trim(),
                        Cidade = txCidade.Text.Trim(),
                        Estado = txEstado.Text.Trim(),
                        Numero = txNumero.Text.Trim(),
                        CEP = txCEP.Text.Trim(),
                        Filial = "Não".Trim(),
                        Adicionado_em = DateTime.Now
                    });
                }
                else
                {
                    _controller.Novo(new empresas
                    {
                        Razao = txRazao.Text.Trim(),
                        Fantasia = txFantasia.Text.Trim(),
                        CNPJ = txCNPJ.Text.Trim(),
                        Telefone1 = txTel1.Text.Trim(),
                        Telefone2 = txTel2.Text.Trim(),
                        Email = txEmail.Text.Trim(),
                        Website = txSite.Text.Trim(),
                        Filial_Numero = "".Trim(),
                        CNPJ_Sede = "".Trim(),
                        Rua = txRua.Text.Trim(),
                        Bairro = txBairro.Text.Trim(),
                        Cidade = txCidade.Text.Trim(),
                        Estado = txEstado.Text.Trim(),
                        Numero = txNumero.Text.Trim(),
                        CEP = txCEP.Text.Trim(),
                        Filial = "Sim".Trim(),
                        Adicionado_em = DateTime.Now
                    });

                }
            }
        }

            
        
        void clear()
        {
            txRazao.Text = txFantasia.Text = txCNPJ.Text = txTel1.Text = txTel2.Text = txEmail.Text = txSite.Text = txFilial.Text = txSede.Text = txRua.Text = txBairro.Text =
                txCidade.Text = txEstado.Text = txCEP.Text = txNumero.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                txFilial.Enabled = true;
                txSede.Enabled = true;
                panelFilial.BackColor = Color.White;
                panelCPNJ.BackColor = Color.White;
            }
            else
            {
                txFilial.Enabled = false;
                txSede.Enabled = false;
                panelFilial.BackColor = Color.Red;
                panelCPNJ.BackColor = Color.Red;
            }
        }

        private void txEmail_Leave(object sender, EventArgs e)
        {
            try
            {
                var add = new MailAddress(txEmail.Text);
                errorProvider1.Clear();
            }catch(Exception ex)
            {
                errorProvider1.SetError(this.txEmail, "Por favor, Digite um endereço de email valido");
            }

        }
    }
}
