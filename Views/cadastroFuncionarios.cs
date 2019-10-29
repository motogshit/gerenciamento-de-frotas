using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemasfrotas.Views
{
    public partial class cadastroFuncionarios : Form
    {
        private string _state { get; set; }
        private int _id { get; set; }

        private systemDB db = new systemDB();

        public cadastroFuncionarios()
        {
            InitializeComponent();
            
                cbEmpresa.ValueMember = "CNPJ";

                cbEmpresa.DisplayMember = "Razao";
                
                cbEmpresa.DataSource = db.empresas.ToList();
            
        }

        public cadastroFuncionarios(funcionarios edit,string state)
        {
            InitializeComponent();
            clear();
            _state = state;
            _id = edit.ID;
            editar(edit);
        }

        private void editar(funcionarios dados)
        {
            List<empresas> emp = new List<empresas>();

            
                dados = db.funcionarios.Where(x => x.ID == dados.ID).FirstOrDefault();


                emp = db.empresas.Where(x => x.CNPJ == dados.CNPJ_Empresa).ToList();
            
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
            cbEmpresa.DataSource = emp;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            funcionarios fun = new funcionarios();

            if(_state == "update")
            {
                funcionarios upd = db.funcionarios.First(x => x.ID == _id);

                upd.Nome = txNome.Text.Trim();
                upd.Cargo = txCargo.Text.Trim();
                upd.CPF = txCPF.Text.Trim();
                upd.CHN = txCHN.Text.Trim();
                upd.Telefone = txTelefone.Text.Trim();
                upd.Rua = txRua.Text.Trim();
                upd.Bairro = txBairro.Text.Trim();
                upd.Cidade = txCidade.Text.Trim();
                upd.Estado = txEstado.Text.Trim();
                upd.Numero_da_casa = txCasa.Text.Trim();
                upd.Numero_Cracha = txCracha.Text.Trim();
                upd.CNPJ_Empresa = cbEmpresa.SelectedValue.ToString();

                db.SaveChanges();
            }
            else
            {
                fun.Nome = txNome.Text.Trim();
                fun.Cargo = txCargo.Text.Trim();
                fun.CPF = txCPF.Text.Trim();
                fun.CHN = txCHN.Text.Trim();
                fun.Telefone = txTelefone.Text.Trim();
                fun.Rua = txRua.Text.Trim();
                fun.Bairro = txBairro.Text.Trim();
                fun.Cidade = txCidade.Text.Trim();
                fun.Estado = txEstado.Text.Trim();
                fun.Numero_da_casa = txCasa.Text.Trim();
                fun.Numero_Cracha = txCracha.Text.Trim();
                fun.CNPJ_Empresa = cbEmpresa.SelectedValue.ToString();
                fun.Adicionado_em = DateTime.Now;

                if (db.funcionarios.Where(x => x.CPF == fun.CPF).FirstOrDefault() == null)
                {
                    db.funcionarios.Add(fun);
                    db.SaveChanges();
                    clear();
                }
                else
                {
                    MessageBox.Show("Este CPF já está cadastrado, verifique o usuario na lista","Erro ao cadastrar", MessageBoxButtons.OK);
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

        private void atualizaEmpresas_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
