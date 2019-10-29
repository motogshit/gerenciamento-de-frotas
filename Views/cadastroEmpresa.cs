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
    public partial class CadastroEmpresa : Form
    {
        private string _state { get; set; }
        private int _id { get; set; }

        private systemDB db = new systemDB();
        public CadastroEmpresa()
        {
            InitializeComponent();
            clear();
        }
        
        public CadastroEmpresa(empresas edit, string state)
        {
            InitializeComponent();
            clear();
            _state = state;
            _id = edit.ID;
            editar(edit);
        }

        private void editar(empresas informaçoes)
        {
                if(informaçoes.Filial == "Sim")
                {
                    checkBox1.Checked = true;
                }
                informaçoes = db.empresas.Where(x => x.ID == informaçoes.ID).FirstOrDefault();
            
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
            empresas emp = new empresas();

            if(_state == "update")
            {
                    empresas c = db.empresas.First(x => x.ID == _id);

                    c.Razao = txRazao.Text.Trim();
                    c.Fantasia = txFantasia.Text.Trim();
                    c.CNPJ = txCNPJ.Text.Trim();
                    c.Telefone1 = txTel1.Text.Trim();
                    c.Telefone2 = txTel2.Text.Trim();
                    c.Email = txEmail.Text.Trim();
                    c.Website = txSite.Text.Trim();
                    c.Filial_Numero = txFilial.Text.Trim();
                    c.CNPJ_Sede = txSede.Text.Trim();
                    c.Rua = txRua.Text.Trim();
                    c.Bairro = txBairro.Text.Trim();
                    c.Cidade = txCidade.Text.Trim();
                    c.Estado = txEstado.Text.Trim();
                    c.Numero = txNumero.Text.Trim();
                    c.CEP = txCEP.Text.Trim();

                    db.SaveChanges();
            }
            else
            {
                emp.Razao = txRazao.Text.Trim();
                emp.Fantasia = txFantasia.Text.Trim();
                emp.CNPJ = txCNPJ.Text.Trim();
                emp.Telefone1 = txTel1.Text.Trim();
                emp.Telefone2 = txTel2.Text.Trim();
                emp.Email = txEmail.Text.Trim();
                emp.Website = txSite.Text.Trim();
                emp.Filial_Numero = txFilial.Text.Trim();
                emp.CNPJ_Sede = txSede.Text.Trim();
                emp.Rua = txRua.Text.Trim();
                emp.Bairro = txBairro.Text.Trim();
                emp.Cidade = txCidade.Text.Trim();
                emp.Estado = txEstado.Text.Trim();
                emp.Numero = txNumero.Text.Trim();
                emp.CEP = txCEP.Text.Trim();

                if (checkBox1.CheckState == CheckState.Checked)
                {
                    emp.Filial = "Sim".Trim();

                    if (db.empresas.Where(x => x.CNPJ_Sede == emp.CNPJ_Sede).FirstOrDefault() != null)
                    {
                        MessageBox.Show("A empresa sede existe");
                        if (db.empresas.Where(x => x.CNPJ == emp.CNPJ).FirstOrDefault() == null)
                        {
                            db.empresas.Add(emp);
                            db.SaveChanges();
                        }
                        else
                        {
                            db.Entry(emp).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                        }

                    }
                    clear();
                }
                else
                {
                    emp.Filial = "Não".Trim();
                    emp.CNPJ_Sede = "".Trim();
                    emp.Filial_Numero = "".Trim();
                    emp.Adicionado_em = DateTime.Now;
                    db.empresas.Add(emp);
                    db.SaveChanges();
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
    }
}
