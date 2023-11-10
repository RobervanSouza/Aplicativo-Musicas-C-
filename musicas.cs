
     class Musica
    {
       public  string nome;
       public string artista;
       public int duracao;
       public bool disponivel;

     public void ExibirFichaMusicas() 
     {
        Console.WriteLine($"Nome: {nome} ");
        Console.WriteLine($"Artista: {artista} ");
        Console.WriteLine($"Duração: {duracao} ");

        if (disponivel)
        {
            Console.WriteLine("Musica Disponivel no plano plus");

        }
        else
        {
            Console.WriteLine("Não disponivel no plano, Adquira um plano plus");
        }
    
     } 
}

