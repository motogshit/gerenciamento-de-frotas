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
        public cadastroFuncionarios()
        {
            InitializeComponent();
            using(systemDB db = new systemDB())
            {
                cbEmpresa.ValueMember = "CNPJ";

                cbEmpresa.DisplayMember = "Razao";
                
                cbEmpresa.DataSource = db.empresas.ToList();
            }
        }

        public cadastroFuncionarios(funcionarios edit)
        {
            InitializeComponent();
            clear();
            editar(edit);
        }

        private void editar(funcionarios dados)
        {
            List<empresas> emp = new List<empresas>();

            using (systemDB db = new systemDB())
            {
                dados = db.funcionarios.Where(x => x.ID == dados.ID).FirstOrDefault();


                emp = db.empresas.Where(x => x.CNPJ == dados.CNPJ_Empresa).ToList();
            }
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
            cbEmpresa.ValueMember = "Razao";
            cbEmpresa.DisplayMember = "CNPJ";
            cbEmpresa.DataSource = emp;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            funcionarios fun = new funcionarios();

            using (systemDB db = new systemDB())
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

                if(db.funcionarios.Where(x => x.CPF == fun.CPF).FirstOrDefault() == null)
                {
                    db.funcionarios.Add(fun);
                    db.SaveChanges();
                }
                else
                {
                    db.Entry(fun).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                clear();
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
