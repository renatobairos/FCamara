using System;

namespace FCamara
{
    class Program
    {
        static void Main(string[] args)
        {

            int qtdeSoldados;
            int posicaoSobrevivente = 1;
            int expoenteBase2;
            int inicioSequenciaExpoente;

            do {
            Console.Write("Digite a quantidade de soldados => ");
            qtdeSoldados = Convert.ToInt32(Console.ReadLine());

            } while (qtdeSoldados < 1);

            expoenteBase2 = (int) Math.Log2(qtdeSoldados);
            inicioSequenciaExpoente = (int) Math.Pow(2, expoenteBase2);

            for (var i = inicioSequenciaExpoente; i < qtdeSoldados; i++) {
                posicaoSobrevivente += 2;
            }

            Console.WriteLine("Posição do soldado sobrevivente => " + posicaoSobrevivente);

        }
    }
}