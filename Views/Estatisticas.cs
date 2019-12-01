using System;
using System.ComponentModel;
using System.Windows.Forms;
using sistemasfrotas.Controller;

namespace sistemasfrotas.Views
{
    public partial class Estatisticas : UserControl, IObserver
    {

        private static Estatisticas _instance;

        public delegate void onClick(object sender, EventArgs e);

        public event onClick Atualizar;
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
        private estatisticasController c = new estatisticasController();
        
        public Estatisticas()
        {
            InitializeComponent();
            updateCharts();
            c.GetCount();
        }

        private void updateCharts()
        {
            chart1.Series["Teste"].Points.Clear();
            chart1.Titles.Clear();
            foreach (var entradas in c.ObterPorFuncionarios())
            {
                chart1.Series["Teste"].Points.AddXY(entradas.Texto, entradas.Count);
            }
            chart1.Series["Teste"].IsValueShownAsLabel = true;
            chart1.Titles.Add("Grafico das Empresas com mais funcionarios");

            chart2.Series["Teste"].Points.Clear();
            chart2.Titles.Clear();
            foreach (var entradas in c.ObterPorMarca())
            {
                chart2.Series["Teste"].Points.AddXY(entradas.Texto, entradas.Count);
            }
            chart2.Series["Teste"].IsValueShownAsLabel = true;
            chart2.Titles.Add("Grafico das Marcas com maior numero");

            chart3.Series["Teste"].Points.Clear();
            chart3.Titles.Clear();
            foreach (var entradas in c.ObterPorModelo())
            {
                chart3.Series["Teste"].Points.AddXY(entradas.Texto, entradas.Count);
            }
            chart3.Series["Teste"].IsValueShownAsLabel = true;
            chart3.Titles.Add("Graficos dos modelos com maior numero");

            chart4.Series["Teste"].Points.Clear();
            chart4.Titles.Clear();
            foreach (var entradas in c.ObterPorDisponibilidade())
            {
                chart4.Series["Teste"].Points.AddXY(entradas.Texto, entradas.Count);
            }
            chart4.Series["Teste"].IsValueShownAsLabel = true;
            chart4.Titles.Add("Grafico da disponibilidade dos veiculos");


            //Grafico 5
            chart5.Series["Teste"].Points.Clear();
            chart5.Titles.Clear();
            foreach (var entradas in c.GetCount())
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
