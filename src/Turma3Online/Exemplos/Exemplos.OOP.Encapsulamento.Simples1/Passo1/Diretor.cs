namespace Exemplos.OOP.Encapsulamento.Simples1.Passo1 {

    class Diretor : Funcionario {

        protected override decimal SalarioBase {
            get { return 300; }
        }

        public override decimal CalcularSalario() {
            return SalarioBase + CalcularBonus();
        }

        public override decimal CalcularBonus() {
            return SalarioBase * 3;
        }
    }
}
