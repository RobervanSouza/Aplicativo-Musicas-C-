//Apicativo musica

Banda banda1 = new Banda();
banda1.Nome = "banda1";

Album albumArtista1 = new Album();
albumArtista1.Nome = "Album musica 1";

Musica musica1 = new Musica(banda1);
musica1.Nome = "musica1";
musica1.Duracao = 212;


Musica musica2 = new Musica(banda1);
musica2.Nome = "musica2";
musica2.Duracao = 313;

Musica musica3 = new Musica(banda1);
musica3.Nome = "musica3";
musica3.Duracao = 414;

albumArtista1.AdicinarMusica(musica1);
albumArtista1.AdicinarMusica(musica2);
albumArtista1.AdicinarMusica(musica3);
albumArtista1.ExibirMusicasAlbum();
banda1.AdicionarAlbum(albumArtista1);
banda1.ExibirDiscografia();













//Musica musica1 = new Musica();
//Console.WriteLine("****************************************************");
//Console.WriteLine("Artista 01");

//musica1.Nome = "primeira musica";
//musica1.Artista = "artista1";
//musica1.Duracao = 112;
//musica1.Disponivel = (true);

//Console.WriteLine(musica1.Disponivel);
//Console.WriteLine(musica1.DescricaoBanda);
//musica1.ExibirFichaMusicas();

//Musica musica2 = new Musica();
//Console.WriteLine("\n****************************************************");
//Console.WriteLine("Artista 02");
//musica2.Nome = "musica2";
//musica2.Artista = "artista2";
//musica2.Disponivel = (false);
//Console.WriteLine(musica2.Disponivel);
//musica2.Duracao = 112;
//musica2.ExibirFichaMusicas();




// Exemplo sem Lambda
//List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//List<int> numerosPares = numeros.FindAll(BuscarNumerosQueSaoPares);

//bool BuscarNumerosQueSaoPares(int numero)
//{
//    return numero % 2 == 0;
//}

//foreach (int numero in numerosPares)
//{
//    Console.WriteLine(numero);
//}

// #####################     Exemplo com o Lambda   ##################################3
//List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//List<int> numerosPares = numeros.FindAll(numero => numero % 2 == 0);
//numerosPares.ForEach(numero => Console.WriteLine(numero));