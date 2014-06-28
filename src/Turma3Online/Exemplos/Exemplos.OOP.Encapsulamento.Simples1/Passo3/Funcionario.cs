namespace Exemplos.OOP.Encapsulamento.Simples1.Passo3 {
    public abstract class Funcionario {

        protected abstract decimal SalarioBase { get; }

        public virtual decimal CalcularSalario() {
            return SalarioBase;
        }
    }
}
