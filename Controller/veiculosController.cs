using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistemasfrotas.Model;
using sistemasfrotas.Repositorio;

namespace sistemasfrotas.Controller
{
    class veiculosController
    {
        private VeiculosRepositorio _repositorio;
        public veiculosController()
        {
            _repositorio = new VeiculosRepositorio();
        }

        public List<veiculos> ListarTodos()
        {
            return _repositorio.GetVeiculos();
        }
        public List<veiculos> ListarPorEmpresa(string s)
        {
            return _repositorio.ObterPorEmpresa(s);
        }
        public veiculos ObterPorId(int id)
        {
            return _repositorio.ObterPorId(id);
        }
        public void Atualizar(veiculos dados)
        {
            _repositorio.Atualizar(dados);
            _repositorio.Salvar();
        }

        public void Adicionar(veiculos dados)
        {
            _repositorio.Add(dados);
            _repositorio.Salvar();
        }
    }
}
