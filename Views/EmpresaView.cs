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
            using (systemDB db = new systemDB())
            {
                //Busca das informações no banco de dados sem usar parametros (Carrega todos os registros da tabela)
                dataGridView1.DataSource = db.empresas.ToList();
            }
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
            empresas c = new empresas();
            //Seleciona a linha no DataGridView
            if (dataGridView1.CurrentRow.Index != -1)
            {
                //Pega o id daquela linha e armazena no objeto empresa
                c.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
                //PEga a informação se a empresa é uma filial e adiciona no objeto empresa
                c.Filial = Convert.ToString(dataGridView1.CurrentRow.Cells["Filial"].Value);

                //Chama o construtor do form de cadastro de empresas com construtor personalizado para receber um objeto empresa como argumento
                CadastroEmpresa form = new CadastroEmpresa(c, "update");
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
            empresas c = new empresas();
            RemoverController rmv = new RemoverController();
            if (MessageBox.Show("Você deseja remover este registro?", "Aviso de exclusão de dados", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dataGridView1.CurrentRow.Index != -1)
                {
                    c.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
                    rmv.removerRegistro(c);
                    MessageBox.Show("Registro Removido com sucesso!", "Alerta de remoção de dados", MessageBoxButtons.OK);
                    PopularGrid();                                         
                }
                    
            }
        }
    }
}
