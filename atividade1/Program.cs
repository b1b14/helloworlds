using atividade1;

internal class Program
{
    private static void Main()
    {
        livro livro1 = new livro
        {
            titulo = "O Senhor dos Anéis",
            autor = "J.R.R. Tolkien",
            editora = "HarperCollins",
            anoLancamento = 1954

        };
        livro livro2 = new livro
        {
            titulo = "Aprendendo C#",
            autor = "João Silva",
            editora = "Editora Exemplo",
            anoLancamento = 2023

        };
        livro livro3 = new livro
        {
            titulo = "Harry Potter",
            autor = "J.K. Rowling",
            editora = "Globo",
            anoLancamento = 1999

        };
        Console.WriteLine($"Título: {livro1.titulo} | {livro1.autor} | {livro1.editora} | {livro1.anoLancamento} ");
        Console.WriteLine($"Título: {livro2.titulo} | {livro2.autor} | {livro2.editora} | {livro2.anoLancamento} ");
        Console.WriteLine($"Título: {livro3.titulo} | {livro3.autor} | {livro3.editora} | {livro3.anoLancamento} ");


        var Aluno1 = new Aluno
        {
            rm = 4365,
            nome = "gabrieli",
            nascimento = new DateTime(2008, 05, 20),
            email = "gabi.raimundodasilva.@gmail.com"
        };

        var Aluno2 = new Aluno
        {
            rm = 4215,
            nome = "pedro",
            nascimento = new DateTime(2008, 05, 11),
            email = "pedro.ladygaga.@gmail.com"
        };
        var Aluno3 = new Aluno
        {
            rm = 4543,
            nome = "ray",
            nascimento = new DateTime(2008, 03, 03),
            email = "rayaneDosSantos@gmail.com"
        };

        Console.WriteLine($"\nrm: {Aluno1.rm} | nome: {Aluno1.nome} | nascimento: {Aluno1.nascimento: dd/MM/yyyy} | email: {Aluno1.email}");
        Console.WriteLine($"\nrm: {Aluno2.rm} | nome: {Aluno2.nome} | nascimento: {Aluno2.nascimento: dd/MM/yyyy} | email: {Aluno2.email}");
        Console.WriteLine($"\nrm: {Aluno3.rm} | nome: {Aluno3.nome} | nascimento: {Aluno3.nascimento: dd/MM/yyyy} | email: {Aluno3.email}");


        Console.WriteLine("--------------------------------------------");


        var produto1 = new Produto
        {
            Codigo = 1,
            Nome = "Caneta",
            Preco = 1.50m,
            Estoque = 2
        };

        var produto2 = new Produto
        {
            Codigo = 2,
            Nome = "Papel",
            Preco = 10.50m,
            Estoque = 9
        };

        var produto3 = new Produto
        {
            Codigo = 3,
            Nome = "Tesoura",
            Preco = 9.90m,
            Estoque = 7
        };
        Console.WriteLine($"\nCodigo: {produto1.Codigo}");
        Console.WriteLine($"Nome: {produto1.Nome}");
        Console.WriteLine($"Preço: {produto1.Preco:C}");
        Console.WriteLine($"Estoque: {produto1.Estoque}");
        Console.WriteLine($" Total de Estoque: {produto3.ValorEstoque():0.00}");


        Console.WriteLine($"\nCodigo: {produto2.Codigo}");
        Console.WriteLine($"Nome: {produto2.Nome}");
        Console.WriteLine($"Preço: {produto2.Preco:C}");
        Console.WriteLine($"Estoque: {produto2.Estoque}");
        Console.WriteLine($" Total de Estoque: {produto3.ValorEstoque():0.00}");


        Console.WriteLine($"\nCodigo: {produto3.Codigo}");
        Console.WriteLine($"Nome: {produto3.Nome}");
        Console.WriteLine($"Preço: {produto3.Preco:C}");
        Console.WriteLine($"Estoque: {produto3.Estoque}");
        Console.WriteLine($" Total de Estoque: {produto3.ValorEstoque():0.00}");

        var carro1 = new Carro
        {
            Marca = "Fiat",
            Modelo = "Uno",
            Velocidade = 80,

        };

        Console.WriteLine($"\nMarca: " + carro1.Marca);
        Console.WriteLine($"Modelo: " + carro1.Modelo);
        Console.WriteLine($"Velocidade: " + carro1.Velocidade);
        Console.WriteLine($"Velocidade Atual: {carro1.Acelerar(10):km/h}");
        Console.WriteLine($"Velocidade Atual: {carro1.Desacelerar(-100):km/h}");




        var f1 = new Funcionario("Ana", 25, "Analista");
        var f2 = new Funcionario("Joana", 27, "Medica");
        var f3 = new Funcionario("Luiza", 28, "Pediatra");

        f1.Envelhecer(5);
        f2.Envelhecer(7);
        f3.Envelhecer(6);


        var Gato = new Gato();
        var Porco = new Porco();
        var Capivara = new Capivara();

        Gato.Exibir();
        Gato.EmitirSom();

        Porco.Exibir();
        Porco.EmitirSom();

        Capivara.Exibir();
        Capivara.EmitirSom();
    }

}