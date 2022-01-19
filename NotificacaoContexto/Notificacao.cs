namespace Orientacao_Objetos.NotificacaoContexto
{
    public sealed class Notificacao
    {
        public Notificacao()
        {

        }

        public Notificacao(string propriedade, string mensagem)
        {
            Propriedade = propriedade;
            Mensagem = mensagem;
        }

        public string Mensagem { get; set; }
        public string Propriedade { get; set; }
    }
}