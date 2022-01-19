using Orientacao_Objetos.NotificacaoContexto;

namespace Orientacao_Objetos.ContextoCompartilhado
{
    public abstract class Base : Notificavel
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}