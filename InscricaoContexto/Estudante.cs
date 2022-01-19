using Orientacao_Objetos.ContextoCompartilhado;
using Orientacao_Objetos.NotificacaoContexto;

namespace Orientacao_Objetos.InscricaoContexto
{
    public class Estudante : Base
    {
        public Estudante()
        {
            Inscricoes = new List<Inscricao>();
        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public Usuario Usuario { get; set; }

        public IList<Inscricao> Inscricoes { get; set; }

        public void CriarInscricao(Inscricao inscricao)
        {
            if (Premium)
            {
                AddNotificacao(new Notificacao("Premium", "O aluno já tem assinatura ativa"));
                return;
            }

            Inscricoes.Add(inscricao);
        }

        public bool Premium => Inscricoes.Any(x => !x.Inativo);
    }
}