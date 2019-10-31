using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemasfrotas.Controller;
using sistemasfrotas.Model;
namespace sistemasfrotas.Views
{
    public partial class EmpresaView : UserControl
    {
        private static EmpresaView _instance;

        public static EmpresaView Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new EmpresaView();
                    return _instance;
                }
                else
                {
                    return _instance;
                }
            }
        }
        public EmpresaView()
        {
            InitializeComponent();

            //Gatilho para carregar informações no DataGridView
            PopularGrid();
        }

        public void PopularGrid()
        {
            //Instancia da conexão
            empresaController c = new empresaController();
            dataGridView1.DataSource = c.ListarTodos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Carrega o form para cadastro de empresa
            CadastroEmpresa form = new CadastroEmpresa();
            if(form.ShowDialog() == DialogResult.OK)
            {
                //Apos inserir as informações atualiza o data grid
                PopularGrid();
            }
            else
            {
                //Atualiza o data grid
                PopularGrid();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Carrega o objeto empresa
            //Seleciona a linha no DataGridView
            if (dataGridView1.CurrentRow.Index != -1)
            {
                //Chama o construtor do form de cadastro de empresas com construtor personalizado para receber um objeto empresa como argumento
                CadastroEmpresa form = new CadastroEmpresa(Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value), "update");
                //Independente do resultado atualiza o DataGridView
                if (form.ShowDialog() == DialogResult.OK)
                {
                    PopularGrid();
                }
                else
                {
                    PopularGrid();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja remover este registro?", "Aviso de exclusão de dados", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dataGridView1.CurrentRow.Index != -1)
                {
                    empresaController c = new empresaController();
                    c.RemoverEmpresa(Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value));
                    MessageBox.Show("Registro Removido com sucesso!", "Alerta de remoção de dados", MessageBoxButtons.OK);
                    PopularGrid();                                         
                }
                    
            }
        }
    }
}
