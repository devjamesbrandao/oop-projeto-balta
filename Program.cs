// See https://aka.ms/new-console-template for more information
using Orientacao_Objetos.ConteudoContexto;

var artigos = new List<Artigo>();

artigos.Add(new Artigo("Artigo sobre OOP", "orientacao-objetos"));

artigos.Add(new Artigo("Artigo sobre C#", "csharp"));

artigos.Add(new Artigo("Artigo sobre .NET", "dotnet"));

var cursos = new List<Curso>();

var courseOOP = new Curso("Fundamentos OOP", "fundamentos-oop");

var courseCsharp = new Curso("Fundamentos C#", "fundamentos-csharp");

var courseAspNet = new Curso("Fundamentos ASP.NET", "fundamentos-aspnet");

cursos.Add(courseOOP);

cursos.Add(courseCsharp);

cursos.Add(courseAspNet);

var carreiras = new List<Carreira>();

var careerDotnet = new Carreira("Especialista .NET", "especialista-dotnet");

var careerItem2 = new CarreiraItem(2, "Aprenda OOP", "", null);

var careerItem = new CarreiraItem(1, "Comece por aqui", "", courseCsharp);

var careerItem3 = new CarreiraItem(3, "Aprenda .NET", "", courseAspNet);

careerDotnet.Items.Add(careerItem2);

careerDotnet.Items.Add(careerItem3);

careerDotnet.Items.Add(careerItem);

carreiras.Add(careerDotnet);

foreach (var carreira in carreiras)
{
    Console.WriteLine(carreira.Titulo);

    foreach (var item in carreira.Items.OrderBy(x => x.Ordem))
    {
        Console.WriteLine($"{item.Ordem} - {item.Titulo}");

        Console.WriteLine(item.Curso);

        Console.WriteLine(item.Curso?.Nivel);

        foreach (var notificacao in item.Notificacaos)
        {
            Console.WriteLine($"{notificacao.Propriedade} - {notificacao.Mensagem}");
        }
    }
}