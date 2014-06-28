using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos.OOP.Heranca.Simples1.PorComposicao.Exemplo2Antes {
    public abstract class Pessoa {
        public Pessoa() {
        }

        public void Falar(string algumaCoisa) {
            Console.WriteLine(algumaCoisa);
        }

        public void Reclama(string algumaCoisa) {
            Falar(String.Format(":( {0} :(", algumaCoisa));
        }
    }

    public class Funcionario : Pessoa {

    }

    public class Sindicalista : Pessoa {

    }
}
