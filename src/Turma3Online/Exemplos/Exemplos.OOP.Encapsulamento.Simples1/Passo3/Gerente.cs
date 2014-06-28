namespace Exemplos.OOP.Encapsulamento.Simples1.Passo3 {
    class Gerente : Executivo {

        protected override int FatorBonus {
            get { return 2; }
        }

        protected override decimal SalarioBase {
            get { return 200; }
        }
    }
}
