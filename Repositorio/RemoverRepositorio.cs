using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistemasfrotas.Model;

namespace sistemasfrotas.Repositorio
{
    class RemoverRepositorio
    {
        private systemDB dbContext;
        public RemoverRepositorio()
        {
            dbContext = new systemDB();
        }
        public void RemoveEmployer(funcionarios dados)
        {
            dados = dbContext.funcionarios.FirstOrDefault(x => x.ID == dados.ID);
            alugados codigo = dbContext.alugados.FirstOrDefault(x => x.Codigo_funcionario == dados.ID);
            veiculos atualizaVeiculo = dbContext.veiculos.AsNoTracking().FirstOrDefault(x => x.ID == codigo.codigo_carro);
            atualizaVeiculo.Status = "Disponivel";
            dbContext.Set<veiculos>().AddOrUpdate(atualizaVeiculo);
            dbContext.alugados.RemoveRange(dbContext.alugados.Where(x => x.Codigo_funcionario == dados.ID));
            dbContext.recibos.RemoveRange(dbContext.recibos.Where(x => x.Cod_Funcionario == dados.ID));
            try
            {
                SaveChanges();
            }catch(Exception ex)
            {
            }
            finally
            {
                dbContext.funcionarios.Remove(dados);
                try
                {
                    SaveChanges();
                }catch(Exception ex)
                {
                }
            }

        }
        public void RemoveCompany(empresas dados)
        {
            dados = dbContext.empresas.FirstOrDefault(x => x.ID == dados.ID);
            dbContext.recibos.RemoveRange(dbContext.recibos.Where(x => x.CNPJ == dados.CNPJ));
            dbContext.manutencao.RemoveRange(dbContext.manutencao.Where(x => x.cnpj == dados.CNPJ));
            dbContext.alugados.RemoveRange(dbContext.alugados.Where(x => x.cnpj == dados.CNPJ));
            dbContext.veiculos.RemoveRange(dbContext.veiculos.Where(x => x.cnpj == dados.CNPJ));
            dbContext.funcionarios.RemoveRange(dbContext.funcionarios.Where(x => x.CNPJ_Empresa == dados.CNPJ));
            try
            {
                SaveChanges();
            }catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Falha ao remover informações relacionadas a empresa!", "Aviso de exclusão de dados", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                System.Windows.Forms.MessageBox.Show("Todos os dados relacionados a empresa foram removidos!", "Aviso de exclusão de dados", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                try
                {
                    List<empresas> empresa = dbContext.empresas.Where(x => x.CNPJ_Sede == dados.CNPJ).ToList();

                    foreach (var item in empresa)
                    {
                        RemoveCompany(item);
                    }

                }catch(Exception ex)
                {
                 
                }
                finally
                {
                    dbContext.empresas.RemoveRange(dbContext.empresas.Where(x => x.CNPJ_Sede == dados.CNPJ));
                }
                dbContext.empresas.Remove(dados);
                try
                {
                    SaveChanges();
                }catch(Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Falha ao remover as empresas filiais e sede", "Aviso de exclusão de dados", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
                finally
                {
                    System.Windows.Forms.MessageBox.Show("A empresa e todas as suas informações foram removidas com sucesso!", "Aviso de exclusão de dados", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                }
            }
        }

        public void SaveChanges()
        {
            dbContext.SaveChanges();
        }
    }
}
