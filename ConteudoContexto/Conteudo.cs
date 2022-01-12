namespace Orientacao_Objetos.ConteudoContexto
{
    public abstract class Conteudo
    {
        public Conteudo(string titulo, string url)
        {
            Titulo = titulo;
            Url = url;
        }

        public string Titulo { get; set; }
        public string Url { get; set; }
    }
}