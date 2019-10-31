using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistemasfrotas.Repositorio;
using sistemasfrotas.Model;

namespace sistemasfrotas.Controller
{
    class alugadosController
    {
        private AlugarRepositorio _repositorio;
        public alugadosController()
        {
            _repositorio = new AlugarRepositorio();
        }
        public alugados ObterPorId(int id)
        {
            return _repositorio.GetById(id);
        }
        public alugados ObterPorCodigo(int codigo)
        {
            return _repositorio.GetByCarCode(codigo);
        }
        public void Alugar(alugados dados)
        {
            _repositorio.AlugarCarro(dados);
            _repositorio.Salvar();
        }
        public void Devolver(alugados dados)
        {
            _repositorio.DevolverCarro(dados);
            _repositorio.Salvar();  
        }
        public alugados VerificarCarro(int codigo_carro)
        {
            return _repositorio.verificarVeiculo(codigo_carro);
        }
        public alugados VerificarFuncionario(int codigo_funcionario)
        {
            return _repositorio.verificarFuncionario(codigo_funcionario);
        }
    }
}
