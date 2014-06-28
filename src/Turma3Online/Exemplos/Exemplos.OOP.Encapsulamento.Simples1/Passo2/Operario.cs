namespace Exemplos.OOP.Encapsulamento.Simples1.Passo2 {
    public class Operario : Funcionario {
        protected override decimal SalarioBase {
            get { return 100; }
        }
    }
}
