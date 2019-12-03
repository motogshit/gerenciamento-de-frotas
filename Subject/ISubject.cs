using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasfrotas.Subject
{
    interface ISubject
    {
        //Métodos da interface de observação que recebem um IOBserver como parametro
        void RegisterObserver(IObserver observer);
        void UnregisterObserver(IObserver observer);
        void NotifyObservers(int count);
    }
}
