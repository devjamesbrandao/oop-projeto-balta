using Orientacao_Objetos.ContextoCompartilhado;

namespace Orientacao_Objetos.ConteudoContexto
{
    public class Leitura : Base
    {
        public int Ordem { get; set; }
        public string Titulo { get; set; }
        public int DuracaoEmMinutos { get; set; }
        public NivelDeConteudo Nivel { get; set; }
    }
}