namespace Exemplos.OOP.Encapsulamento.Simples1.Passo1 {
    class Gerente : Funcionario {

        protected override decimal SalarioBase {
            get { return 200; }
        }

        public override decimal CalcularSalario() {
            return SalarioBase + CalcularBonus();
        }

        public override decimal CalcularBonus() {
            return SalarioBase * 2;
        }
    }
}
