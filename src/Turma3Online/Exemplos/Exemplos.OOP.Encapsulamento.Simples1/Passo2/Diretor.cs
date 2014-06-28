namespace Exemplos.OOP.Encapsulamento.Simples1.Passo2 {

    class Diretor : Funcionario, ICalcularBonus {

        protected override decimal SalarioBase {
            get { return 300; }
        }

        public override decimal CalcularSalario() {
            return SalarioBase + CalcularBonus();
        }

        public decimal CalcularBonus() {
            return SalarioBase * 3;
        }
    }
}
