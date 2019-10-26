using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasfrotas.Controller
{
    class RemoverController
    {
        public void removerRegistro(empresas dados)
        {
            using(systemDB db = new systemDB() )
            {
                var entry = db.Entry(dados);
                if(entry.State == System.Data.Entity.EntityState.Detached)
                {
                    db.empresas.Attach(dados);
                }
                db.empresas.Remove(dados);
                db.SaveChanges();
            }
        }

        public string removerFuncionario(funcionarios dados)
        {
            using(systemDB db = new systemDB())
            {
                var entry = db.Entry(dados);
                if (entry.State == System.Data.Entity.EntityState.Detached)
                {
                    db.funcionarios.Attach(dados);
                }
                db.funcionarios.Remove(dados);
                db.SaveChanges();
                return "Registro removido com sucesso!";
            }
        }
    }
}
