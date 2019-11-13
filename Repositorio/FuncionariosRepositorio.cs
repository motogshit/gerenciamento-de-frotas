using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.Migrations;
using System.Text;
using System.Threading.Tasks;
using sistemasfrotas.Model;
using System.Data.Entity.Core.Objects;

namespace sistemasfrotas.Repositorio
{
    class FuncionariosRepositorio
    {
        private systemDB dbContext;

        public FuncionariosRepositorio()
        {
            dbContext = new systemDB();
        }

        public List<funcionarios> GetFuncionarios()
        {
            return dbContext.funcionarios.AsNoTracking().ToList();
        }

        public void NovoFuncionario(funcionarios dados)
        {
            dbContext.funcionarios.Add(dados);
        }
        public void Salvar()
        {
            dbContext.SaveChanges();
        }

        public void Atualizar(funcionarios dados)
        {
            dbContext.Set<funcionarios>().AddOrUpdate(dados);
        }

        public void Excluir(int id)
        {
            dbContext.funcionarios.Remove(dbContext.funcionarios.FirstOrDefault(x => x.ID == id));
        }

        public funcionarios ObterPorId(int id)
        {
            return dbContext.funcionarios.AsNoTracking().FirstOrDefault(x => x.ID == id);
        }

        public List<funcionarios> ObterPorEmpresas(string CNPJ)
        {
            return dbContext.funcionarios.AsNoTracking().Where(x => x.CNPJ_Empresa == CNPJ).ToList();
        }

        public funcionarios ObterPorCPF(string s)
        {
            return dbContext.funcionarios.AsNoTracking().FirstOrDefault(x => x.CPF == s);
        }

        public List<funcionarios> ObterRelatorioPorEmpresa(string s, DateTime d1, DateTime d2)
        {
            return dbContext.funcionarios.AsNoTracking().Where(x => x.CNPJ_Empresa == s && EntityFunctions.TruncateTime(x.Adicionado_em) >= d1 && EntityFunctions.TruncateTime(x.Adicionado_em) <= d2).ToList();
        }
    }
}
