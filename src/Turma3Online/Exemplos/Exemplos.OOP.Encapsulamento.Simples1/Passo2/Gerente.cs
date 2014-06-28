namespace Exemplos.OOP.Encapsulamento.Simples1.Passo2 {
    class Gerente : Funcionario, ICalcularBonus {

        protected override decimal SalarioBase {
            get { return 200; }
        }

        public override decimal CalcularSalario() {
            return SalarioBase + CalcularBonus();
        }

        public decimal CalcularBonus() {
            return SalarioBase * 2;
        }
    }
}
