using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistemasfrotas.Model;

namespace sistemasfrotas.Repositorio
{
    class VeiculosRepositorio
    {
        private systemDB dbContext;
        public VeiculosRepositorio()
        {
            dbContext = new systemDB();
        }

        public List<veiculos> GetVeiculos()
        {
            return dbContext.veiculos.AsNoTracking().ToList();
        }
        public void Salvar()
        {
            dbContext.SaveChanges();
        }
        public void Atualizar(veiculos dados)
        {
            dbContext.Set<veiculos>().AddOrUpdate(dados);
        }
        public List<veiculos> ObterPorEmpresa(string s)
        {
            return dbContext.veiculos.AsNoTracking().Where(x => x.cnpj == s).ToList();
        }
        public veiculos ObterPorId(int id)
        {
            return dbContext.veiculos.AsNoTracking().FirstOrDefault(x => x.ID == id);
        }

        public void RemoverVeiculo(int id)
        {
            dbContext.veiculos.Remove(dbContext.veiculos.FirstOrDefault(x => x.ID == id));
        }
        public void Add(veiculos dados)
        {
            dbContext.veiculos.Add(dados);
        }
        public List<veiculos> ObterRelatorioPorEmpresa(string s, DateTime d1, DateTime d2)
        {
            return dbContext.veiculos.AsNoTracking().Where(x => x.cnpj == s && EntityFunctions.TruncateTime(x.Adicionado_em) >= d1 && EntityFunctions.TruncateTime(x.Adicionado_em) <= d2).ToList();
        }
    }
}
