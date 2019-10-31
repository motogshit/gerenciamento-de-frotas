using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistemasfrotas.Model;
using sistemasfrotas.Repositorio;

namespace sistemasfrotas.Controller
{
    class funcionarioController
    {
        FuncionariosRepositorio _funcionariosRepositorio;
        public funcionarioController()
        {
            _funcionariosRepositorio = new FuncionariosRepositorio();
        }

        public List<funcionarios> ListarTodos()
        {
            return _funcionariosRepositorio.GetFuncionarios();
        }
        public void Novo(funcionarios dados)
        {
            _funcionariosRepositorio.NovoFuncionario(dados);
            _funcionariosRepositorio.Salvar();
        }

        public void AtualizarFuncionario(funcionarios dados)
        {
            _funcionariosRepositorio.Atualizar(dados);
            _funcionariosRepositorio.Salvar();
        }

        public funcionarios BuscarPorId(int id)
        {
           return _funcionariosRepositorio.ObterPorId(id);
        }
        public List<funcionarios> ObterPorEmpresa(string CNPJ)
        {
            return _funcionariosRepositorio.ObterPorEmpresas(CNPJ);
        }

        public void RemoverFuncionario(int id)
        {
            _funcionariosRepositorio.Excluir(id);
            _funcionariosRepositorio.Salvar();
        }

        public funcionarios LocalizarCPF(string s)
        {
            return _funcionariosRepositorio.ObterPorCPF(s);
        }
    }
}
