using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasfrotas
{
    public interface IObserver
    {
        //Métodos do observador
        void Update(int count);
    }
}
