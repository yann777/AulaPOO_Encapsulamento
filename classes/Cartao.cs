namespace POO_Encapsulamento.classes
{
    public class Cartao
    {
        private string numero;

        public string Numero{
            get{ return numero; }
            set{ numero = value; }
        }

        private string bandeira = "masterCard";

        public string Bandeira{
            get{ return bandeira; }
            // set{ bandeira = value; }
        }

        protected string token = "qwertyui";

        public string Token{
            get{ return token; }
        }

        private string cvv;

        public string Cvv{
            get{ return cvv; }
            set{ cvv = value; }
        }
        protected float limiteDeCompra = 5000;

        public float LimiteDeCompra{
            get{ return limiteDeCompra;}
        }


        public string RegistrarCompra(bool validado){
            return "";
        }

        private bool ValidarCompra(float saldo){
            return true;
        }

        protected string ValidarToken(){
            return "";
        }
    }
}