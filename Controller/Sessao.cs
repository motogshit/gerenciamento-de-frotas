using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasfrotas.Controller
{
    public static class Sessao
    {
        private static int _nivelAcesso;
        private static string _usuario;
        private static string _senha;
        //Classe estatica, valores definidos aqui podem ser acessados de qualquer lugar
        public static string Usuario
        {
            get { return Sessao._usuario; }
            set { Sessao._usuario = value; }
        }
        public static string Senha
        {
            get { return Sessao._senha; }
            set { Sessao._senha = value; }
        }

        public static int NivelAcesso
        {
            get { return Sessao._nivelAcesso; }
            set { Sessao._nivelAcesso = value; }
        }
        
    }
}
