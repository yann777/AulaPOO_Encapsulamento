namespace POO_Encapsulamento.classes
{
    public class Mastercard : Cartao
    {
        private int parcelas;

        public int Parcelas{
            get{ return parcelas; }
            set{ parcelas = value; }
        }

        public string ComprarComDesconto(){
            
            return "";
        }

    }
}