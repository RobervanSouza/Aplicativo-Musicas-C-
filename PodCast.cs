class PodCast
{
    private List<Episodio> episodioList = new();
    public PodCast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get; }
    public string Host { get; }

    public int TotalEpsodios => episodioList.Count;

    public void AdicionarEpisodios (Episodio episodio)
    {
        episodioList.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($" PodCast {Nome} Apresentado por {Host}\n ");
        foreach (Episodio episodio in episodioList.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"\n\n Este episodio possui {TotalEpsodios} episodios ");
    }
}