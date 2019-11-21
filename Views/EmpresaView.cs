using System;
using System.Windows.Forms;
using sistemasfrotas.Controller;
using System.Globalization;

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
        private empresaController c = new empresaController();
        private exclusaoController exc = new exclusaoController();
        private CultureInfo cultureInfo = new CultureInfo("pt-BR");
        public EmpresaView()
        {
            InitializeComponent();
            //Gatilho para carregar informações no DataGridView0
            PopularGrid();

            //EmpresaRepositorio emp = new EmpresaRepositorio();
            //chart1.DataSource = emp.Top5();
            //chart1.Series.Add("Teste");
            //chart1.Series.RemoveAt(0);
            //chart1.Series["Teste"].XValueMember = "razao";
            //chart1.Series["Teste"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            //chart1.Series["Teste"].YValueMembers = "count";
            //chart1.Series["Teste"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            
            //chart1.DataBind();
        }

        public void PopularGrid()
        {
            //Instancia da conexão
            
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
                form.Dispose();
            }
            else
            {
                //Atualiza o data grid
                PopularGrid();
                form.Dispose();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Carrega o objeto empresa
            //Seleciona a linha no DataGridView
            if (dataGridView1.CurrentRow.Index != -1)
            {
                //Chama o construtor do form de cadastro de empresas com construtor personalizado para receber um objeto empresa como argumento
                CadastroEmpresa form = new CadastroEmpresa(Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value , cultureInfo), "update");
                //Independente do resultado atualiza o DataGridView
                if (form.ShowDialog() == DialogResult.OK)
                {
                    PopularGrid();
                    form.Dispose();
                    form = null;
                }
                else
                {
                    PopularGrid();
                    form.Dispose();
                    form = null;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Properties.Resources.PerguntaExclusao,Properties.Resources.Aviso_Exclusao, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (new Confirmacao().ShowDialog() == DialogResult.OK)
                {
                    if (dataGridView1.CurrentRow.Index != -1)
                    {
                        exc.ExcluirEmpresa(new Model.empresas
                        {
                            ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value, cultureInfo)
                        });
                        MessageBox.Show("Dados excluidos","Alerta de exclusão de dados",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PopularGrid();
                        Sessao.Update = 1;
                    }
                }
                else
                {
                    PopularGrid();
                }
                    
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
