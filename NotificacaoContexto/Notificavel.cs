namespace Orientacao_Objetos.NotificacaoContexto
{
    public abstract class Notificavel
    {
        public List<Notificacao> Notificacaos { get; set; }

        public Notificavel()
        {
            Notificacaos = new List<Notificacao>();
        }

        public void AddNotificacao(Notificacao notificacao)
        {
            Notificacaos.Add(notificacao);
        }

        public void AddNotificaos(IEnumerable<Notificacao> notificacaos)
        {
            Notificacaos.AddRange(notificacaos);
        }

        public bool IsInvalid => Notificacaos.Any();
    }
}