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
    public partial class cadastroVeiculos : Form
    {
        private string _state { get; set; }
        private int _id { get; set; }

        private systemDB db = new systemDB();

        List<empresas> emp = new List<empresas>();

        empresas razao = new empresas();

        public cadastroVeiculos()
        {
            InitializeComponent();

            cbEmpresas.ValueMember = "CNPJ";
            cbEmpresas.DisplayMember = "Razao";
            cbEmpresas.DataSource = db.empresas.ToList();

            lbStatus.Visible = false;
            date.Visible = false;
        }

        public cadastroVeiculos(veiculos edit, string s)
        {
            InitializeComponent();
            _state = s;
            _id = edit.ID;
            editar(edit);
            lbStatus.Visible = true;
            date.Visible = true;
        }

        private void editar(veiculos dados)
        {
            

            dados = db.veiculos.Where(x => x.ID == dados.ID).FirstOrDefault();

            emp = db.empresas.Where(x => x.CNPJ == dados.cnpj).ToList();

            razao = db.empresas.Where(x => x.CNPJ == dados.cnpj).FirstOrDefault();

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
            cbEmpresas.DataSource = emp;

        }
        private void btSalvar_Click(object sender, EventArgs e)
        {
            veiculos vc = new veiculos();

            if(_state == "update")
            {
                veiculos upd = db.veiculos.First(x => x.ID == _id);

                upd.Modelo = txModelo.Text.Trim();
                upd.Marca = txMarca.Text.Trim();
                upd.Ano = txAno.Text.Trim();
                upd.Placa_Veiculo = txPlaca.Text.Trim();
                upd.Numero_chassi = txChassi.Text.Trim();
                upd.Km_Inicial = txKm.Text.Trim();
                upd.Km_Atual = txKm.Text.Trim();
                upd.empresa = razao.Razao;
                upd.cnpj = cbEmpresas.SelectedValue.ToString().Trim();
                upd.Status = "Disponivel";
                upd.Adicionado_em = Convert.ToDateTime(date.Text);

                db.SaveChanges();

            }
            else
            {
                razao = db.empresas.Where(x => x.CNPJ == cbEmpresas.SelectedValue.ToString()).FirstOrDefault();
                vc.Modelo = txModelo.Text.Trim();
                vc.Marca = txMarca.Text.Trim();
                vc.Ano = txAno.Text.Trim();
                vc.Placa_Veiculo = txPlaca.Text.Trim();
                vc.Numero_chassi = txChassi.Text.Trim();
                vc.Km_Inicial = txKm.Text.Trim();
                vc.Km_Atual = txKm.Text.Trim();
                vc.empresa = razao.Razao;
                vc.cnpj = cbEmpresas.SelectedValue.ToString().Trim();
                vc.Status = "Disponivel";
                vc.Adicionado_em = DateTime.Now;

                if (db.veiculos.Where(X => X.Placa_Veiculo == vc.Placa_Veiculo).FirstOrDefault() == null)
                {
                    db.veiculos.Add(vc);
                    db.SaveChanges();
                    clear();
                }
                else
                {
                    MessageBox.Show("A placa " + vc.Placa_Veiculo + " Já está cadastrada", "Erro ao cadastrar", MessageBoxButtons.OK);
                }
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
