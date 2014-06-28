namespace Exemplos.OOP.Encapsulamento.Simples1.Passo1 {
    public class Operario : Funcionario {

        protected override decimal SalarioBase {
            get { return 100; }
        }

        public override decimal CalcularBonus() {
            return 0;
        }
    }
}
