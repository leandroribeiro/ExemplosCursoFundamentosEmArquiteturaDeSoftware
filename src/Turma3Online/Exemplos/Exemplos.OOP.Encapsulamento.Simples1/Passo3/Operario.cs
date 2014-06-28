namespace Exemplos.OOP.Encapsulamento.Simples1.Passo3 {
    public class Operario : Funcionario {
        protected override decimal SalarioBase {
            get { return 100; }
        }
    }
}
