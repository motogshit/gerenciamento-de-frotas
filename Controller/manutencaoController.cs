using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistemasfrotas.Repositorio;
using sistemasfrotas.Model;

namespace sistemasfrotas.Controller
{
    class manutencaoController
    {
        private ManutencaoRepositorio _repo;

        public manutencaoController()
        {
            _repo = new ManutencaoRepositorio();
        }

        public List<manutencao> ObterTodos()
        {
            return _repo.GetAll();
        }

        public void Devolver(manutencao dados)
        {
            _repo.GiveBack(dados);
        }
        public List<manutencao> ObterRelatorio(string cnpj,DateTime d1, DateTime d2)
        {
            return _repo.GetReport(cnpj, d1, d2);
        }
        public void Adicionar(manutencao dados)
        {
            _repo.Add(dados);
        }

        public manutencao ObterPorID(int id)
        {
            return _repo.GetByID(id);
        }

        public void Salver()
        {
            _repo.Save();
        }
    }
}
