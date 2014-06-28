namespace Exemplos.OOP.Encapsulamento.Simples1.Passo1 {
    public abstract class Funcionario {

        protected abstract decimal SalarioBase { get; }

        public virtual decimal CalcularSalario() {
            return SalarioBase;
        }

        public abstract decimal CalcularBonus();

    }
}
