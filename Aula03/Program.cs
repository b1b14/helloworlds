using Aula03;

Console.WriteLine("Trabalhando com listas!");

List<string> lista = new List<string>();
lista.Add("Maçã");
lista.Add("Banana");
lista.Add("Morango");
lista.Add("Melão");

Console.WriteLine("\nImprimindo os valores da 'List' na tela");
foreach (string item in lista)
{
    Console.WriteLine(item);
}

Console.WriteLine("\nImprimir um item na posição específica");
Console.WriteLine($"Item na posição 2: {lista[2]}");

Console.WriteLine("\nAdicionar um item na posição específica");
lista.Insert(2, "Laranja");

Console.WriteLine("\nImprimindo os valores da 'List' na tela");
foreach (string item in lista)
{
    Console.WriteLine(item);
}

Console.WriteLine("\nAlterar um item da lista específica");
lista[4] = "uva";

foreach (string item in lista)
{
    Console.WriteLine(item);
}

Console.WriteLine("\nRemover um item da lista na posição");
lista.RemoveAt(3);
foreach (string item in lista)
{
    Console.WriteLine(item);
}

Console.WriteLine(" Trabalhando com as Listas de Alunos");

List<Aluno> listaAlunos = new List<Aluno>();
listaAlunos.Add(new Aluno(1, "Ray"));
listaAlunos.Add(new Aluno(2, "Gabi"));
listaAlunos.Add(new Aluno(3, "Pedro"));
listaAlunos.Add(new Aluno(4, "Anna"));
listaAlunos.Add(new Aluno(5, "Yasmin"));

Console.WriteLine("\nImprimindo os valores da 'List'  de alunos na tela");
foreach (Aluno aluno in listaAlunos)
{
    Console.WriteLine($"Código: {aluno.codigo}, Nome: {aluno.nome}");
}


Dictionary<int, string> dicionario = new Dictionary<int, string>();

// Adicionando itens ao dicionário
dicionario.Add(10, "Ka");
dicionario.Add(20, "Fusca");
dicionario.Add(30, "Civic");
dicionario.Add(40, "Corolla");

Console.WriteLine("\nImprimindo os valores do 'Dictionary' na tela com KeyValuePair()");
foreach (KeyValuePair<int, string> item in dicionario)
{
    // Imprimir chave e valor do dicionário
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("\nImprimindo os valores do 'Dictionary' na tela com var");
foreach (var item in dicionario)
{
    // Imprimir chave e valor do dicionário
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

// Alterar valor de um item no dicionário
Console.WriteLine("\nAlterando os valores do 'Dictionary'");
dicionario[10] = "Corsa";
foreach (var item in dicionario)
{
    // Imprimir chave e valor do dicionário
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

// Pesquisando um item no dicionário por valor
Console.WriteLine("\nPesquisando um item no dicionário por chave");
string carro;

bool carroExiste = dicionario.TryGetValue(30, out carro);

if (carroExiste)
{
    Console.WriteLine($"O valor encontrado para a chave 30 é: {carro}");
}
else
{
    Console.WriteLine("A chave 30 não foi encontrada");
}

// Excluindo um item por Chave
dicionario.Remove(30);
foreach (var item in dicionario)
{
    // Imprimir chave e valor do dicionário
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("\n******************************* Trabalhando com Fila *******************************");

// Criar uma coleção de dados do tipo fila (Queue => Fila)
Queue<string> fila = new Queue<string>();

// Adicionar elementos da fila
fila.Enqueue("Kaique");
fila.Enqueue("Leo");
fila.Enqueue("Gabi");

foreach (var pessoa in fila)
{
    // Imprimir chave e valor do dicionário
    Console.WriteLine(pessoa);
}


// Tirar os elementos da fila
string primeiroFila = fila.Dequeue();
Console.WriteLine($"\n{primeiroFila} é o primeiro,e saiu da fila\n");
foreach (var pessoa in fila)
{
    // Imprimir chave e valor do dicionário
    Console.WriteLine(pessoa);
}

// Todo novo item é inserido no final da fila
fila.Enqueue("Victhor");
Console.WriteLine("\n");

foreach (var pessoa in fila)
{
    // Imprimir chave e valor do dicionário
    Console.WriteLine(pessoa);
}

// Procurar por um elemento na fila
bool achou = fila.Contains("Leo");

if (achou)
    Console.WriteLine("\nNome Encontrado");
else
    Console.WriteLine("\nO Nome não está na lista");


Console.WriteLine("\n******************************* Trabalhando com Pilhas *******************************");

// Criar uma Pilha de elementos (Stack => Pilha)
Stack<string> pilha = new Stack<string>();

// Adicionar itens em uma pilha
pilha.Push("Harry Potter");
pilha.Push("Cosmos");
pilha.Push("Morro dos Ventos Uivantes");

// Imprimir elementos da pilha
foreach (var livro in pilha)
{
    Console.WriteLine(livro);
}

// Remover o primeiro item da pilha
string livroRetirado = pilha.Pop();
Console.WriteLine($"\nO livro retirado da pilha de livros foi: {livroRetirado}\n");

// Imprimir elementos da pilha
foreach (var livro in pilha)
{
    Console.WriteLine(livro);
}

// Pesquisar um item dentro da pilha
if (pilha.Contains("Cosmos"))
    Console.WriteLine("O Livro foi encontrado");
else
    Console.WriteLine("O Livro nao está na lista");


Console.WriteLine("\n******************************* Trabalhando com HashSet *******************************");

// HashSet é uma lista que nao permite itens repetidos

// Criar um HashSet
HashSet<string> listaUnica = new HashSet<string>();

// Adicionar itens no HashSet
listaUnica.Add("Manga");
listaUnica.Add("Goiaba");
listaUnica.Add("Maça");
listaUnica.Add("Melancia");

// Inclusão de um item repetido (sem efeito)
listaUnica.Add("Goiaba");

// Imprime a lista unica
foreach (var unica in listaUnica)
{
    Console.WriteLine(unica);
}
Console.WriteLine(); // "Escreve" uma Linha em branco

// Remover um item da lista Unica
listaUnica.Remove("Goiaba");
foreach (var unica in listaUnica)
{
    Console.WriteLine(unica);
}

// Procurar um elementos na HashSet
bool temManga = listaUnica.Contains("Manga");

if (temManga)
    Console.WriteLine("\nSim, temos manga");
else
    Console.WriteLine("\nNão, não temos manga.");
    }