namespace Exemplos.OOP.Encapsulamento.Simples1.Passo3 {
    public abstract class Executivo : Funcionario, ICalcularBonus {

        protected abstract int FatorBonus { get; }

        public override decimal CalcularSalario() {
            return SalarioBase + CalcularBonus();
        }

        public decimal CalcularBonus() {
            return SalarioBase * FatorBonus;
        }
    }
}
