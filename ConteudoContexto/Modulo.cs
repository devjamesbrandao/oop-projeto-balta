namespace Orientacao_Objetos.ConteudoContexto
{
    public class Modulo
    {
        public Modulo()
        {
            Leituras = new List<Leitura>();
        }

        public int Ordem { get; set; }
        public string Titulo { get; set; }
        public IList<Leitura> Leituras { get; set; }
    }
}