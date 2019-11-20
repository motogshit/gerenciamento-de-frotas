using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistemasfrotas.Model;
using sistemasfrotas.Repositorio;
namespace sistemasfrotas.Controller
{
    class relatoriosController
    {

        private FuncionariosRepositorio _funcionarios;
        private VeiculosRepositorio _veiculos;
        private RecibosRepositorio _recibos;
        private AlugarRepositorio _alugados;
        private ManutencaoRepositorio _manutencao;
        public relatoriosController()
        {
            _funcionarios = new FuncionariosRepositorio();
            _veiculos = new VeiculosRepositorio();
            _recibos = new RecibosRepositorio();
            _alugados = new AlugarRepositorio();
            _manutencao = new ManutencaoRepositorio();
        }

        public List<funcionarios> ListarFuncionariosPorEmpresa(string s, DateTime d1, DateTime d2)
        {
            return _funcionarios.ObterRelatorioPorEmpresa(s,d1,d2);
        }

        public List<veiculos> ListarVeiculosPorEmpresa(string s, DateTime d1, DateTime d2)
        {
            return _veiculos.ObterRelatorioPorEmpresa(s, d1, d2);
        }
        public List<recibos> ListarRecibosPorEmpresa(string s, DateTime d1, DateTime d2)
        {
            return _recibos.ObterRelatorioPorEmpresa(s, d1, d2);
        }
        public List<alugados> ListarAlugadosPorEmpresa(string s, DateTime d1, DateTime d2)
        {
            return _alugados.ObterRelatorioPorEmpresa(s, d1, d2);
        }

        public List<manutencao> ListarManutencaoPorEmpresa(string s, DateTime d1, DateTime d2)
        {
            return _manutencao.GetReport(s, d1, d2);
        }
    }
}
