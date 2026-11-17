using System;

namespace Bancoksi.wdf
{
    internal class Globais
    {
        internal struct Utilizador
        {
            public string email;
            public string palavraPasse;
            public DateTime dataNascimento;
        }

        public static Utilizador[] listaUtilizadores =
            new Utilizador[50];

        // próxima posição vazia
        public static int posicaoVazia = 0;

        // utilizador com sessão iniciada
        public static int utilizadorAtual = -1;
    }
}
