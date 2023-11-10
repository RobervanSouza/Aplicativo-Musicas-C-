//Apicativo musica

 Musica musica1 = new Musica();
Console.WriteLine("****************************************************");
Console.WriteLine("Artista 01");

musica1.nome = "primeira musica";
musica1.duracao = 112;
musica1.artista = "artista1"; 
musica1.disponivel = true;
musica1.ExibirFichaMusicas();

Musica musica2 = new Musica();
Console.WriteLine("\n****************************************************");
Console.WriteLine("Artista 02");
musica2.nome = "musica2";
musica2.artista = "artista2";
musica2.disponivel = false;
musica2.duracao = 112;
musica2.ExibirFichaMusicas();
