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
        public CadastroEmpresa()
        {
            InitializeComponent();
            clear();
        }
        
        public CadastroEmpresa(empresas edit)
        {
            InitializeComponent();
            clear();
            editar(edit);
        }

        private void editar(empresas informaçoes)
        {
            using(systemDB db = new systemDB())
            {
                if(informaçoes.Filial == "Sim")
                {
                    checkBox1.Checked = true;
                }
                informaçoes = db.empresas.Where(x => x.ID == informaçoes.ID).FirstOrDefault();
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
            txCEP.Text = informaçoes.CEP; ;
        }

        private void btSave_Click(object sender, EventArgs coco)
        {
            empresas emp = new empresas();

            
            using (systemDB db = new systemDB())
            {
                if(checkBox1.CheckState == CheckState.Checked)
                {
                    emp.Filial = "Sim".Trim();

                    if(db.empresas.Where(x => x.CNPJ_Sede == emp.CNPJ_Sede).FirstOrDefault() != null)
                    {
                        MessageBox.Show("A empresa sede existe");
                        if(db.empresas.Where(x => x.CNPJ == emp.CNPJ).FirstOrDefault() == null)
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
