using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistemasfrotas.Model;
using sistemasfrotas.Repositorio;

namespace sistemasfrotas.Controller
{
    class exclusaoController
    {
        private RemoverRepositorio _repo;
        public exclusaoController()
        {
            _repo = new RemoverRepositorio();
        }

        public void ExcluirEmpresa(empresas dados)
        {
            _repo.RemoveCompany(dados);
        }
        
        public void ExcluirFuncionario(funcionarios dados)
        {
            _repo.RemoveEmployer(dados);
        }
    }
}
