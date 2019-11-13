using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistemasfrotas.Model;

namespace sistemasfrotas.Repositorio
{
    class EstatisticasRepositorio
    {
        private systemDB dbContext;

        public EstatisticasRepositorio()
        {
            dbContext = new systemDB();
        }

        public List<Contadores> CountByEmplooyers()
        {
            var query = dbContext.funcionarios
                .AsNoTracking()
                .GroupBy(a => new { a.CNPJ_Empresa })
                .Select(b => new { cn = b.Key.CNPJ_Empresa, count = b.Count() })
                .OrderByDescending(c => c.count)
                .Take(5)
                .ToDictionary(d => d.cn, e => e.count);

            List<Contadores> dados = new List<Contadores>();

            foreach (var c in query)
            {
                empresas obj = new empresas();
                obj = dbContext.empresas.AsNoTracking().FirstOrDefault(x => x.CNPJ == c.Key);

                dados.Add(new Contadores
                {
                    Texto = obj.Razao,
                    Count = c.Value
                });


            }
            return dados;
        }

        public List<Contadores> CountByModels()
        {
            var query = dbContext.veiculos
                .AsNoTracking()
                .GroupBy(a => new { a.Modelo })
                .Select(b => new { modelo = b.Key.Modelo, count = b.Count() })
                .OrderByDescending(c => c.count)
                .Take(5)
                .ToDictionary(d => d.modelo, f => f.count);
            List<Contadores> dados = new List<Contadores>();
            foreach (var c in query)
            {
                dados.Add(new Contadores
                {
                    Texto = c.Key,
                    Count = c.Value
                });
            }
            return dados;
        }

        public List<Contadores> CountByBrands()
        {
            var query = dbContext.veiculos
                .AsNoTracking()
                .GroupBy(a => new { a.Marca })
                .Select(b => new { marca = b.Key.Marca, count = b.Count() })
                .OrderByDescending(c => c.count)
                .Take(5)
                .ToDictionary(d => d.marca, f => f.count);

            List<Contadores> dados = new List<Contadores>();

            foreach (var c in query)
            {
                dados.Add(new Contadores
                {
                    Texto = c.Key,
                    Count = c.Value
                });
            }

            return dados;
        }

        public List<Contadores> GetByStatus()
        {
            var query = dbContext.veiculos
                .AsNoTracking()
                .GroupBy(a => a.Status)
                .Select(b => new { status = b.Key, count = b.Count() })
                .OrderByDescending(c => c.count)
                .Take(5)
                .ToDictionary(d => d.status, f => f.count);

            List<Contadores> dados = new List<Contadores>();

            foreach (var c in query)
            {
                dados.Add(new Contadores
                {
                    Texto = c.Key,
                    Count = c.Value
                });
            }
            return dados;
        }
        public List<Contadores> GetCounts()
        {
            var query = dbContext.recibos
                .AsNoTracking()
                .GroupBy(a => a.Razao)
                .Select(b => new { razao = b.Key, count = b.Sum(c => c.Valor) })
                .OrderByDescending(d => d.count)
                .Take(5)
                .ToDictionary(f => f.razao, g => g.count);

            List<Contadores> dados = new List<Contadores>();

            foreach (var c in query)
            {
                dados.Add(new Contadores
                {
                    Texto = c.Key,
                    Valor = c.Value
                });
            }
            return dados;
        }
    }
}
