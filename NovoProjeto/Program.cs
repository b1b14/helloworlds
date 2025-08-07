// See https://aka.ms/new-console-template for more information
using NovoProjeto;





internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Criando um Objeto");

        // Instanciando um objeto da classe Pessoa
        Pessoa pessoa1 = new Pessoa();
        pessoa1.Nome = "João";
        pessoa1.CPF = 123456789;
        pessoa1.DataNascimento = new DateOnly(1990, 1, 1);

        // Apresentando o objeto pessoal
        pessoa1.Apresetar();

        // Instanciando um objto da classe Pessoa com o construtor com Parâmetros
        Pessoa pessoa2 = new Pessoa("Maria", 987654321, new DateOnly(1995, 5, 15));

        pessoa2.Apresetar();

        Console.WriteLine("Criando um Objeto Aluno Herdado de pessoa");
        Aluno aluno1 = new Aluno();
        aluno1.Nome = "Carlos";
        aluno1.CPF = 111222333;
        aluno1.DataNascimento = new DateOnly(2000, 3, 20);
        aluno1.Curso = "Engenharia";
        aluno1.Matricula = 2023001;

        Console.WriteLine("criando um Objeto Professor Herdado de pessoa");
        Professor professor1 = new Professor();
        professor1.Nome = "Ana";
        professor1.CPF = 444555666;
        professor1.DataNascimento = new DateOnly(1980, 7, 30);
        professor1.Especialidade = "Matemática";
        professor1.Registro = 12345;
        professor1.Salario = 5000.00;

        professor1.Apresentar();


        var conta1 = new ContaGenerica("Banco Ygona Investimentos", 6769, 13769691, 13000.00m);
        var conta2 = new ContaGenerica("Banco Ygona Investimentos", 6969, 45696354, 13.00m);
        var conta3 = new ContaGenerica("Banco Ygona Investimentos", 1313, 09857403, 24.00m);

        Console.WriteLine($"\nBanco: {conta1.Banco} | Conta:{conta1.Agencia} | Conta:{conta1.Conta} | Saldo:{conta1.Saldo}");
        Console.WriteLine($"\nBanco: {conta2.Banco} | Conta:{conta2.Agencia} | Conta:{conta2.Conta} | Saldo:{conta2.Saldo}");
        Console.WriteLine($"\nBanco: {conta3.Banco} | Conta:{conta3.Agencia} | Conta:{conta3.Conta} | Saldo:{conta3.Saldo}");
        Console.WriteLine($"\nSaque de 100 reais da Conta 1: {conta1.Sacar(100)}");
        Console.WriteLine($"\nDeposito de 100 da Conta 1: {conta1.Sacar(100)}");


        Console.WriteLine("-----------------------------------------------------------------------");

    }




}