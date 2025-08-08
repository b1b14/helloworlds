internal class Program
{
    private static void Main(string[] args)
    {
        List<string> tarefas = new List<string>();
        tarefas.Add("Tomo café da manhã");
        tarefas.Add("Me arrumo");
        tarefas.Add("Estudo");
        tarefas.Add("Almoço");
        tarefas.Add("Durmo");

        Console.WriteLine("Lista de Tarefas:");
        foreach (string tarefa in tarefas)
        {
            Console.WriteLine(tarefa);
        }
        Console.WriteLine("\nAdicionar um item na posição específica");
        tarefas.Insert(2, "EScovo os dentes");


        Console.WriteLine("\nImprimir um item na posição específica");
        Console.WriteLine($"Item na Posição 2: {tarefas[2]}");


        Console.WriteLine("\nRemover um item da lista buscando pelo nome");
        tarefas.Remove("Durmo");
        foreach (string item in tarefas)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\nImprimindo os valores do 'List' na tela");
        foreach (string item in tarefas)
        {
            Console.WriteLine(item);
        }

        Dictionary<int, string> telefone = new Dictionary<int, string>();

        telefone.Add(234985540, "Gabi");
        telefone.Add(776954006, "Anna");
        telefone.Add(033245678, "Pedro");
        telefone.Add(099878654, "Ray");
        telefone.Add(988786543, "Yasmin");

        Console.WriteLine("\nEncontre o número que deseja buscar: ");
        foreach (KeyValuePair<int, string> item in telefone)
        {
            Console.WriteLine($"Número: {item.Key} - Nome: {item.Value}");
        }

        Console.WriteLine("\nImprimindo o número que desejou buscar");
        foreach (var item in telefone)
        {
            Console.WriteLine($"Numero:{item.Key}| Nome: {item.Value}");
        }
        Console.WriteLine("\nAlterando o numero da agenda");

        bool numeroEncontrado = telefone.TryGetValue(123456789, out string nome);

        if (numeroEncontrado)
        {
            Console.WriteLine($"Numero encontrado para a Agenda é: {telefone}");
        }
        else
        {
            Console.WriteLine("Número não encontrado na agenda.");
        }

        telefone.Remove(987654321);
        foreach (var item in telefone)
        {
            Console.WriteLine($"Numero:{item.Key}| Nome: {item.Value}");
        }

        Console.WriteLine("-------------------------------------------------------------");


        Queue<string> fila = new Queue<string>();
        fila.Enqueue("Gabi");
        fila.Enqueue("Anna");
        fila.Enqueue("Pedro");
        fila.Enqueue("Ray");
        fila.Enqueue("Yasmin");

        foreach (string item in fila)
        {
            Console.WriteLine(item);
        }

        string primeiroFila = fila.Dequeue();
        Console.WriteLine($"\n{primeiroFila} é o primeiro, e saiu da fila\n");

        foreach (var pessoa in fila)
        {
            Console.WriteLine(pessoa);
        }

        fila.Enqueue("Carla");
        Console.WriteLine("\n");

        bool encontrou = fila.Contains("Ana");

        if (encontrou)
        {
            Console.WriteLine("Pessoa encontrada na fila!");
        }
        else
        {
            Console.WriteLine("Pessoa não encontrada na fila!");
        }

        Console.WriteLine("-------------------------------------------------------------");

        Stack<string> Paginas = new Stack<string>();
        Paginas.Push("Página 1");
        Paginas.Push("Página 2");
        Paginas.Push("Página 3");

        foreach (var item in Paginas)
        {
            Console.WriteLine(item);
        }

        string ultimaPagina = Paginas.Pop();
        Console.WriteLine($"\n{ultimaPagina} foi a última página visitada e foi removida do histórico.\n");

        foreach (var pagina in Paginas)
        {
            Console.WriteLine(pagina);
        }

        if (Paginas.Contains("Página 2"))
        {
            Console.WriteLine("\nPágina 2 está no histórico.");
        }
        else
        {
            Console.WriteLine("\nPágina 2 não está no histórico.");
        }
        Console.WriteLine("-------------------------------------------------------------");


    }
}
