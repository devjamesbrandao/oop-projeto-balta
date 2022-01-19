using Orientacao_Objetos.ContextoCompartilhado;

namespace Orientacao_Objetos.InscricaoContexto
{
    public class Inscricao : Base
    {
        public Plano Plano {get; set;}
        public DateTime? Fim {get; set;}
        public bool Inativo => Fim <= DateTime.Now;
    }
}