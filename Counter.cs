using sistemasfrotas.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasfrotas
{
    public class Counter : ISubject
    {
        //Cria uma Lista generica privada do tipo IObserver
        private List<IObserver> _observers;
        //Cria uma variavel int privada
        private int _count;

        public Counter()
        {
            //Inicializa uma lista do tipo Observador
            _observers = new List<IObserver>();
            //Inicializa a variavel _count
            _count = 0;
        }

        public void Increment()
        {
            //Aumenta o valor da variavel _count
            _count++;
            //Notifica que houve uma mudança no valor para todos os observadores registrados
            NotifyObservers(_count);
        }
        public void Decrement()
        {
            //Diminui o valor da variavel _count
            if(_count > 0)
            {
                //Reduz em 1 a contagem de _count
                _count--;
                //Notifica que houve uma mudança no valor para todos os observadores registrados
                NotifyObservers(_count);
            }
        }

        public void NotifyObservers(int count)
        {
            //Quando uma alteração é feita no observador e o componente monitorando modificações está registrado ele é notificado que a contagem mudou
            foreach(IObserver ob in _observers)
            {
                //Retorna a nova contagem aos observadores registrados
                ob.Update(count);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            //Registra um novo observador 
            _observers.Add(observer);
        }

        public void UnregisterObserver(IObserver observer)
        {
            //Remove um observador
            _observers.Remove(observer);
        }
    }
}
