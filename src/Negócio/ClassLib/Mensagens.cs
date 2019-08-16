using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio
{
    public static class Mensagens
    {
        public const string INSERCAO_ERRO = "Erro ao processar a inserção. ";
        public const string INSERCAO_FALHA = "Não foi possível processar a inserção. ";
        public const string INSERCAO_SUCESSO = "Inserção completada com sucesso.";

        public const string ALTERACAO_ERRO = "Erro ao processar a alteração. ";
        public const string ALTERACAO_FALHA = "Não foi possível processar a alteração. ";
        public const string ALTERACAO_SUCESSO = "Alteração completada com sucesso.";

        public const string EXCLUSAO_ERRO = "Erro ao processar a exclusão. ";
        public const string EXCLUSAO_FALHA = "Não foi possível processar a exclusão. ";
        public const string EXCLUSAO_SUCESSO = "Exclusão completada com sucesso.";

        public const string SELECAO_NADA_O = "Não foi possível encontrar o {0} desejado";
        public const string SELECAO_NADA_A = "Não foi possível encontrar a {0} desejado";
        public const string SELECAO_ERRO = "Erro ao processar a seleção. ";

        public const string CALCULO_ERRO = "Erro ao processar o cálculo. ";
    }
}
