using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos.OOP.Heranca.Simples1.PorComposicao {

    public interface ISabeReclamar {
        void Reclamar(string algumaCoisa);
    }

    public interface ISabeFalar {
        void Falar(string algumaCoisa);
    }

    public interface IPessoa : ISabeFalar, ISabeReclamar {
    }

    public class Pessoa : IPessoa {
        public Pessoa() {

        }

        public void Falar(string algumaCoisa) {
            Console.WriteLine(algumaCoisa);
        }

        public void Reclamar(string algumaCoisa) {
            Falar(String.Format(":| {0} :(", algumaCoisa));
        }
    }

    public class PessoaPessimista : IPessoa {
        private readonly IPessoa _pessoa;

        public PessoaPessimista(IPessoa pessoa) {
            _pessoa = pessoa;
        }

        public void Falar(string algumaCoisa) {
            _pessoa.Falar(algumaCoisa.ToUpper());
        }

        public void Reclamar(string algumaCoisa) {
            _pessoa.Reclamar(algumaCoisa.ToUpper());
        }
    }
    public class Funcionario : ISabeFalar, ISabeReclamar {

        private readonly IPessoa _pessoa;

        public Funcionario(IPessoa pessoa) {
            _pessoa = pessoa;
        }

        public void Falar(string algumaCoisa) {
            _pessoa.Falar(algumaCoisa);
        }

        public void Reclamar(string algumaCoisa) {
            _pessoa.Reclamar(algumaCoisa);
        }
    }
}
