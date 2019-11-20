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
    class RecibosRepositorio
    {
        private systemDB dbContext;
        public RecibosRepositorio()
        {
            dbContext = new systemDB();
        }

        public List<recibos> GetAllData()
        {
            return dbContext.recibos.AsNoTracking().ToList();
        }

        public List<recibos> GetDataByCompany(string s)
        {
            return dbContext.recibos.AsNoTracking().Where(x => x.CNPJ == s).ToList();
        }

        public recibos GetData(int codigo)
        {
            alugados dadosFuncionario = new alugados();
            
            veiculos dadosVeiculos = new veiculos();
            
            try
            {
                dadosFuncionario = dbContext.alugados.AsNoTracking().FirstOrDefault(x => x.Codigo_funcionario == codigo && x.status == "Em Uso");
                dadosVeiculos = dbContext.veiculos.AsNoTracking().FirstOrDefault(x => x.ID == dadosFuncionario.codigo_carro && x.Status == "Em Uso");
            }
            catch(System.Reflection.TargetException ex)
            {

            }

            recibos retorno = new recibos();
            
            try
            {
                retorno.Nome_Funcionario = dadosFuncionario.Nome;
                retorno.Cod_Funcionario = dadosFuncionario.Codigo_funcionario;
                retorno.Razao = dadosVeiculos.empresa;
                retorno.CNPJ = dadosVeiculos.cnpj;
            }
            catch(System.NullReferenceException ex)
            {
                System.Windows.Forms.MessageBox.Show("Informações Não Encontradas, verifique a credencial e tente novamente. É necessario um registro que possua um carro em uso no momento para lancar um recibo","Erro ao buscar registro", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }

            return retorno;
        }
        public void AddData(recibos dados)
        {
            dbContext.recibos.Add(dados);
        }
        public void SaveChanges()
        {
            dbContext.SaveChanges();
        }
        public List<recibos> ObterRelatorioPorEmpresa(string s, DateTime d1, DateTime d2)
        {
            return dbContext.recibos.AsNoTracking().Where(x => x.CNPJ == s && EntityFunctions.TruncateTime(x.data) >= d1 && EntityFunctions.TruncateTime(x.data) <= d2).ToList();
        }

        public void UpdateValue(recibos dados)
        {
            dbContext.Set<recibos>().AddOrUpdate(dados);
        }

        public recibos GetByMainCode(int id)
        {
            return dbContext.recibos.FirstOrDefault(x => x.CodigoManutencao == id);
        }
    }
}
