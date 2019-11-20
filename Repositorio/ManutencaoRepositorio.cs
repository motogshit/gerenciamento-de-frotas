using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Migrations;
using System.Linq;
using sistemasfrotas.Model;

namespace sistemasfrotas.Repositorio{
    class ManutencaoRepositorio
    {
        private systemDB dbContext;

        public ManutencaoRepositorio()
        {
            dbContext = new systemDB();
        }

        public List<manutencao> GetAll()
        {
            return dbContext.manutencao.AsNoTracking().ToList();
        }

        public void Save()
        {
            dbContext.SaveChanges();
        }

        public void GiveBack(manutencao dados)
        {
            dbContext.Set<manutencao>().AddOrUpdate(dados);
        }
        public List<manutencao> GetReport(string s, DateTime d1, DateTime d2)
        {
            return dbContext.manutencao.AsNoTracking().Where(x => x.cnpj == s && EntityFunctions.TruncateTime(x.Data_Manutencao) >= d1 && EntityFunctions.TruncateTime(x.Data_Manutencao) <= d2).ToList();
        }
        public void Add(manutencao dados)
        {
            dbContext.manutencao.Add(dados);
        }

        public manutencao GetByID(int id)
        {
            return dbContext.manutencao.AsNoTracking().FirstOrDefault(x => x.CodigoCarro == id && x.Status == "Em Manutenção");
        }
    }
}