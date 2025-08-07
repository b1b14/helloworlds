using OO_Aula_01;

internal class Program
{
    private static void Main(string[] args)
    {
        Animal cachorro = new Animal
        {
            Nome = "Rex",
            Idade = 5,
            Especie = "Cachorro"
        };

        Cachorro cachorro2 = new Cachorro
        {

            Nome = "Buddy",
            Idade = 3,
            Especie = "Cachorro",
            Raca = "Labrador",
            TipoAlimentacao = "Ração"
        };
        Console.WriteLine($"Nome: {cachorro.Nome}, Idade: {cachorro.Idade}, Espécie: {cachorro.Especie}");
        Console.WriteLine($"Nome: {cachorro2.Nome}, Idade: {cachorro2.Idade}, Espécie: {cachorro2.Especie}, Raça: {cachorro2.Raca}, Tipo de Alimentação: {cachorro2.TipoAlimentacao}");



        Personagem personagem = new Personagem
        {
            Nome = "Peralta",
            Idade = 39,
            Nivel = 99
        };

        Console.WriteLine($"Nome: {personagem.Nome}, Idade: {personagem.Idade}, Nivel: {personagem.Nivel}");

    }
}