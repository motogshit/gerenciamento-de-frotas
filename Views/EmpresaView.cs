using System;
using System.Windows.Forms;
using sistemasfrotas.Controller;
using System.Globalization;

namespace sistemasfrotas.Views
{
    //Este controle de usuario tambem suporta a interface IObserver que é responsavel por atualizar as informações dos formularios
    public partial class EmpresaView : UserControl, IObserver
    {
        //Cria uma variavel privada estatica do Controle de usuario EmpresaView
        private static EmpresaView _instance;
        //Cria uma variavel publica estatica do controle de usuario EmpresaView e possui um setter
        public static EmpresaView Instance
        {
            //Quando o método GET é chamado
            get
            {
                //Verifica se a instancia privada esta nula ou não inicializada
                if(_instance == null)
                {
                    //Caso esteja nula adiciona uma nova instancia do controle de usuario
                    _instance = new EmpresaView();
                    //Retorna o valor de _instance
                    return _instance;
                }
                else
                {
                    //Caso o valor de _instance não seja nulo, retorna o valor de _instance
                    return _instance;
                }
            }
        }
        private Counter observer;
        private empresaController c = new empresaController();
        private exclusaoController exc = new exclusaoController();
        private CultureInfo cultureInfo = new CultureInfo("pt-BR");
        public EmpresaView()
        {
            InitializeComponent();
            observer = new Counter();
            //Registro do observador, todas as instancias das view foram registradas. Quando houver um Update no observador todas elas vão ser atualizadas
            observer.RegisterObserver(this);
            observer.RegisterObserver(FuncionariosView.Instance);
            observer.RegisterObserver(VeiculosView.Instance);
            observer.RegisterObserver(FinanceiroView.Instance);
            observer.RegisterObserver(Estatisticas.Instance);
            //Gatilho para carregar informações no DataGridView0
            PopularGrid();
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
                observer.Increment();
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
                    observer.Increment();
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
                        observer.Increment();
                    }
                }
                else
                {
                }
                    
            }
        }

        public void Update(int count)
        {
            if(count > 0)
            {
                PopularGrid();
            }
        }
    }
}
