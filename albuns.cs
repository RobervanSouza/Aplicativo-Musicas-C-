class Album
{
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(mus => mus.Duracao);

    public void AdicinarMusica (Musica musica) 
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasAlbum()
    {
        Console.WriteLine($" Lista musicas do album : {Nome} \n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.Nome} ");
        }
        Console.WriteLine($" {DuracaoTotal} Tempo total do Album");
    }
}