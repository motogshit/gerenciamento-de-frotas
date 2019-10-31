using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistemasfrotas.Model;

namespace sistemasfrotas.Repositorio
{
    class EmpresaRepositorio
    {
        private systemDB dBContext;

        public EmpresaRepositorio()
        {
            dBContext = new systemDB();
        }
        public List<empresas> GetEmpresas()
        {
            return dBContext.empresas.ToList();
        }
        
        public void NovaEmpresa(empresas emp)
        {
            dBContext.empresas.Add(emp);
        }
        public void Salvar()
        {
            dBContext.SaveChanges();
        }
        public void Atualizar(empresas updater)
        {
            dBContext.Set<empresas>().AddOrUpdate(updater);
        }


        public void Excluir(int id)
        {
            dBContext.empresas.Remove(dBContext.empresas.FirstOrDefault(x => x.ID == id));
        }

        public empresas ObterPorId(int id)
        {
            return dBContext.empresas.FirstOrDefault(x => x.ID == id);
        }

        public List<empresas> ObterPorCNPJ(string CNPJ)
        {
            return dBContext.empresas.Where(x => x.CNPJ == CNPJ).ToList();
        }
        public empresas ObjetoCNPJ(string CNPJ)
        {
            return dBContext.empresas.FirstOrDefault(x => x.CNPJ == CNPJ);
        }
    }
}
