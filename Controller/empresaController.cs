using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistemasfrotas.Model;
using sistemasfrotas.Repositorio;

namespace sistemasfrotas.Controller
{
    class empresaController
    {
        private EmpresaRepositorio _empresaRepositorio;


        public empresaController()
        {
            _empresaRepositorio = new EmpresaRepositorio();
        }

        public List<empresas> ListarTodos()
        {
            return _empresaRepositorio.GetEmpresas();
        }

        public void Novo(empresas dados)
        {
            _empresaRepositorio.NovaEmpresa(dados);
            _empresaRepositorio.Salvar();
        }

        public void AtualizarEmpresa(empresas dados)
        {
            _empresaRepositorio.Atualizar(dados);
            _empresaRepositorio.Salvar();

        }

        public empresas BuscarPorId(int id)
        {
            return _empresaRepositorio.ObterPorId(id);
        }

        public void RemoverEmpresa(int id)
        {
            _empresaRepositorio.Excluir(id);
            _empresaRepositorio.Salvar();
        }

        public List<empresas> BuscarPorCNPJ(string s)
        {
            return _empresaRepositorio.ObterPorCNPJ(s);
        }

        public empresas ObjetoCNPJ(string s)
        {
            return _empresaRepositorio.ObjetoCNPJ(s);
        }
    }
}
