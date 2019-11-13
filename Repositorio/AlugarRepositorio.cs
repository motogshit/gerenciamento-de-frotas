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
    class AlugarRepositorio
    {
        private systemDB dbContext;

        public AlugarRepositorio()
        {
            dbContext = new systemDB();
        }

        public alugados GetById(int id)
        {
            return dbContext.alugados.AsNoTracking().FirstOrDefault(x => x.ID == id); 
        }

        public alugados GetByCarCode(int id)
        {
            return dbContext.alugados.AsNoTracking().FirstOrDefault(x => x.codigo_carro == id && x.status == "Em Uso");
        }

        public void AlugarCarro(alugados dados)
        {
            dbContext.alugados.Add(dados);
        }
        public void DevolverCarro(alugados dados)
        {
            dbContext.Set<alugados>().AddOrUpdate(dados);
        }
        public void Salvar()
        {
            dbContext.SaveChanges();
        }
        public alugados verificarVeiculo(int codigo_carro)
        {
           return dbContext.alugados.AsNoTracking().FirstOrDefault(x => x.codigo_carro == codigo_carro && x.status == "Em Uso");
        }
        public alugados verificarFuncionario(int codigo_funcionario)
        {
            return dbContext.alugados.AsNoTracking().FirstOrDefault(x => x.Codigo_funcionario == codigo_funcionario && x.status == "Em Uso");
        }

        public List<alugados> ObterRelatorioPorEmpresa(string s, DateTime d1, DateTime d2)
        {
            return dbContext.alugados.AsNoTracking().Where(x => x.cnpj == s && EntityFunctions.TruncateTime(x.Alugado_em) >= d1 && EntityFunctions.TruncateTime(x.Alugado_em) <= d2).ToList();
        }
    }
}
