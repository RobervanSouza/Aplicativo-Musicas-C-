
class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    public string Nome { get;}
    public Banda Artista { get;}
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    public string DescricaoBanda =>
        $"A musica {Nome}, pertence a banda {Artista} ";

    public void ExibirFichaMusicas()
    {
        Console.WriteLine($"Nome: {Nome} ");
        Console.WriteLine($"Artista: {Artista.Nome} ");
        Console.WriteLine($"Duração: {Duracao} ");

        if (Disponivel)
        {
            Console.WriteLine("Musica Disponivel no plano plus");
        }
        else
        {
            Console.WriteLine("Não disponivel no plano, Adquira um plano plus");
        }

    }
}

