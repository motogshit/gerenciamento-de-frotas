using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistemasfrotas.Model;
using sistemasfrotas.Repositorio;

namespace sistemasfrotas.Controller
{
    class estatisticasController
    {
        private EstatisticasRepositorio _repo;
        public estatisticasController()
        {
            _repo = new EstatisticasRepositorio();
        }

        public List<Contadores> ObterPorMarca()
        {
            return _repo.CountByBrands();
        }

        public List<Contadores> ObterPorFuncionarios()
        {
            return _repo.CountByEmplooyers();
        }

        public List<Contadores> ObterPorDisponibilidade()
        {
            return _repo.GetByStatus();
        }
        public List<Contadores> ObterPorModelo()
        {
            return _repo.CountByModels();
        }

        public List<Contadores> GetCount()
        {
           return  _repo.GetCounts();
        }
    }
}
