using System;
using System.Collections.Generic;
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
            return dbContext.veiculos.ToList();
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
            return dbContext.veiculos.Where(x => x.cnpj == s).ToList();
        }
        public veiculos ObterPorId(int id)
        {
            return dbContext.veiculos.FirstOrDefault(x => x.ID == id);
        }

        public void RemoverVeiculo(int id)
        {
            dbContext.veiculos.Remove(dbContext.veiculos.FirstOrDefault(x => x.ID == id));
        }
        public void Add(veiculos dados)
        {
            dbContext.veiculos.Add(dados);
        }
    }
}
