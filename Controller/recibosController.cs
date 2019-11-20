using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistemasfrotas.Model;
using sistemasfrotas.Repositorio;

namespace sistemasfrotas.Controller
{
    class recibosController
    {
        private RecibosRepositorio _repo;
        public recibosController()
        {
            _repo = new RecibosRepositorio();
        }

        public List<recibos> ObterTodos()
        {
            return _repo.GetAllData();
        }

        public List<recibos> ObterPorEmpresa(string CNPJ)
        {
            return _repo.GetDataByCompany(CNPJ);
        }

        public recibos ObterDadosFuncionario(int ID)
        {
            return _repo.GetData(ID);
        }

        public void Salvar()
        {
            _repo.SaveChanges();
        }

        public void AdicionarRecibo(recibos objeto)
        {
            _repo.AddData(objeto);
        }

        public void AtualizarReciboManutencao(recibos objeto)
        {
            _repo.UpdateValue(objeto);
        }

        public recibos ObterPorManutencao(int id)
        {
            return _repo.GetByMainCode(id);
        }
    }
}
