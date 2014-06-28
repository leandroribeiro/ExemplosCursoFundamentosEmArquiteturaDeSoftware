namespace Exemplos.OOP.Encapsulamento.Simples1.Passo3 {

    class Diretor : Executivo {

        protected override decimal SalarioBase {
            get { return 300; }
        }

        protected override int FatorBonus {
            get { return 3; }
        }
    }
}
