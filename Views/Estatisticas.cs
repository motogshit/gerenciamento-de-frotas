using System;
using System.ComponentModel;
using System.Windows.Forms;
using sistemasfrotas.Controller;

namespace sistemasfrotas.Views
{
    public partial class Estatisticas : UserControl, IObserver
    {

        private static Estatisticas _instance;

        public static Estatisticas Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Estatisticas();
                    return _instance;
                }
                else
                {
                    return _instance;
                }
            }
        }
        private estatisticasController _controller = new estatisticasController();
        
        public Estatisticas()
        {
            InitializeComponent();
            updateCharts();
            _controller.GetCount();
        }

        private void updateCharts()
        {
            //Definição da serie a ser usada e limpa todos os pontos antes de inserir informações
            chart1.Series["Teste"].Points.Clear();
            //Limpeza dos titulos dos graficos
            chart1.Titles.Clear();
            //Busca informações no controlador de estatisticas usando o método (OBTER POR FUNCIONARIO) e armazena num var
            foreach (var entradas in _controller.ObterPorFuncionarios())
            {
                //Adiciona o ponto XY (Nome, Valor) do grafico com base na informação do indice de (ENTRADAS) atual
                chart1.Series["Teste"].Points.AddXY(entradas.Texto, entradas.Count);
            }
            //Define que o valor X pode ser usado como label(IDENTIFICACAO)
            chart1.Series["Teste"].IsValueShownAsLabel = true;
            //Adiciona o titulo do gráfico
            chart1.Titles.Add("Grafico das Empresas com mais funcionarios");

            chart2.Series["Teste"].Points.Clear();
            chart2.Titles.Clear();
            foreach (var entradas in _controller.ObterPorMarca())
            {
                chart2.Series["Teste"].Points.AddXY(entradas.Texto, entradas.Count);
            }
            chart2.Series["Teste"].IsValueShownAsLabel = true;
            chart2.Titles.Add("Grafico das Marcas com maior numero");

            chart3.Series["Teste"].Points.Clear();
            chart3.Titles.Clear();
            foreach (var entradas in _controller.ObterPorModelo())
            {
                chart3.Series["Teste"].Points.AddXY(entradas.Texto, entradas.Count);
            }
            chart3.Series["Teste"].IsValueShownAsLabel = true;
            chart3.Titles.Add("Graficos dos modelos com maior numero");

            chart4.Series["Teste"].Points.Clear();
            chart4.Titles.Clear();
            foreach (var entradas in _controller.ObterPorDisponibilidade())
            {
                chart4.Series["Teste"].Points.AddXY(entradas.Texto, entradas.Count);
            }
            chart4.Series["Teste"].IsValueShownAsLabel = true;
            chart4.Titles.Add("Grafico da disponibilidade dos veiculos");


            //Grafico 5
            chart5.Series["Teste"].Points.Clear();
            chart5.Titles.Clear();
            foreach (var entradas in _controller.GetCount())
            {
                chart5.Series["Teste"].Points.AddXY(entradas.Texto, entradas.Valor);
            }
            chart5.Series["Teste"].IsValueShownAsLabel = true;
            chart5.Titles.Add("Grafico das Empresas com mais despesas");
        }
        public void Update(int count)
        {
            updateCharts();
        }
    }
}
