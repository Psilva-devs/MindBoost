using System;
using System.Collections.Generic;

namespace MINDBOOST_3
{
    public static class DadosAtendimento
    {
        public static string CodigoHexadecimal;

        public static string Posto;

        public static int Pontuacao;

        public static List<string> Respostas =
            new List<string>();

        public static string RespostaTexto1;

        public static string RespostaTexto2;

        // ESPECTROS
        public static int EspectroBemEstar;
        public static int EspectroRotina;
        public static int EspectroApoio;
        public static int EspectroPensamentos;
        public static int EspectroMotivacao;

        public static void ProcessarEspectros()
        {
            EspectroBemEstar = 0;
            EspectroRotina = 0;
            EspectroApoio = 0;
            EspectroPensamentos = 0;
            EspectroMotivacao = 0;

            for (int i = 0; i < 25; i++)
            {
                int pergunta = i + 1;

                int valor = ConverterResposta(Respostas[i]);

                // PERGUNTAS NEGATIVAS
                if (pergunta == 6 ||
                    pergunta == 8 ||
                    pergunta == 13 ||
                    pergunta == 16 ||
                    pergunta == 18 ||
                    pergunta == 20 ||
                    pergunta == 22 ||
                    pergunta == 23)
                {
                    valor *= -1;
                }

                // ESPECTRO 1 - BEM ESTAR EMOCIONAL
                if (pergunta == 1 ||
                    pergunta == 2 ||
                    pergunta == 3 ||
                    pergunta == 5 ||
                    pergunta == 24)
                {
                    EspectroBemEstar += valor;
                }

                // ESPECTRO 2 - IMPACTO DA ROTINA
                else if (pergunta == 11 ||
                         pergunta == 6 ||
                         pergunta == 10 ||
                         pergunta == 16 ||
                         pergunta == 21 ||
                         pergunta == 25)
                {
                    EspectroRotina += valor;
                }

                // ESPECTRO 3 - APOIO SOCIAL
                else if (pergunta == 7 ||
                         pergunta == 12 ||
                         pergunta == 15 ||
                         pergunta == 17 ||
                         pergunta == 22)
                {
                    EspectroApoio += valor;
                }

                // ESPECTRO 4 - PENSAMENTOS E PREOCUPAÇÕES
                else if (pergunta == 8 ||
                         pergunta == 13 ||
                         pergunta == 18 ||
                         pergunta == 20 ||
                         pergunta == 23)
                {
                    EspectroPensamentos += valor;
                }

                // ESPECTRO 5 - MOTIVAÇÃO E ADAPTAÇÃO
                else if (pergunta == 9 ||
                         pergunta == 14 ||
                         pergunta == 19 ||
                         pergunta == 4)
                {
                    EspectroMotivacao += valor;
                }
            }
        }

        private static int ConverterResposta(string resposta)
        {
            switch (resposta)
            {
                case "Nunca":
                    return -5;

                case "Raramente":
                    return -3;

                case "As vezes":
                    return 1;

                case "Frequentemente":
                    return 3;

                case "Quase sempre":
                    return 5;

                default:
                    return 0;
            }
        }

        public static string Interpretar(int valor)
        {
            if (valor >= 10)
                return "Positivo";

            if (valor >= 0)
                return "Em observação";

            return "Merece atenção";
        }

        public static void LimparDados()
        {
            CodigoHexadecimal = "";
            Posto = "";
            Pontuacao = 0;

            EspectroBemEstar = 0;
            EspectroRotina = 0;
            EspectroApoio = 0;
            EspectroPensamentos = 0;
            EspectroMotivacao = 0;

            Respostas.Clear();

            RespostaTexto1 = "";
            RespostaTexto2 = "";
        }
    }
}