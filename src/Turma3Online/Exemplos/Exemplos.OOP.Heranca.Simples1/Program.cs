using System;
using Exemplo1 = Exemplos.OOP.Heranca.Simples1.Exemplo1;
using Exemplo2 = Exemplos.OOP.Heranca.Simples1.PorComposicao;
using Exemplo2Antes = Exemplos.OOP.Heranca.Simples1.PorComposicao.Exemplo2Antes;

namespace Exemplos.OOP.Heranca.Simples1 {
    class Program {
        static void Main(string[] args) {
            //Exemplo1();
            Exemplo2();
            //Exemplo2Antes();

            System.Console.ReadLine();
        }

        private static void Exemplo2() {
            var funcionario = new Exemplo2.Funcionario(
                new Exemplo2.PessoaPessimista(
                    new Exemplo2.Pessoa()
                    )
                    );
            funcionario.Falar("Bom dia");
            funcionario.Reclamar("Estou ganhando pouco.");
        }

        private static void Exemplo1() {
            var pessoas = new Exemplo1.Pessoa[]
                {
                    new Exemplo1.Empregado() {Nome = "Huguinho"},
                    new Exemplo1.Estudante() {Nome = "Zezinho Estudantes"}
                };

            foreach (var pessoa in pessoas) {
                Console.Write(pessoa.Nome);
            }
        }
    }
}
