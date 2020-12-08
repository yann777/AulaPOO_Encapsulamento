using System;
using POO_Encapsulamento.classes;

namespace POO_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Mastercard m = new Mastercard();

            m.Parcelas = 12;
            // m.Bandeira = "Visa";

            Console.WriteLine(m.Parcelas);
        }
    }
}
