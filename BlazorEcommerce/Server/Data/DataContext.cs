namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Books",
                    Url = "books"
                },
                new Category
                {
                    Id = 2,
                    Name = "Movies",
                    Url = "movies"
                },
                new Category
                {
                    Id = 3,
                    Name = "Video Games",
                    Url = "video-games"
                }
            );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Retour vers le futur",
                    Description = "Retour vers le futur (Back to the Future) est un film de science-fiction américain réalisé par Robert Zemeckis, sorti en 1985.L'intrigue relate le voyage dans le passé d'un adolescent, Marty McFly, à bord d'une machine à voyager dans le temps fabriquée par le docteur Emmett Brown, à partir d'une voiture de modèle DeLorean DMC-12. Parti de l'année 1985 et propulsé le 5 novembre 1955, Marty, aidé du « Doc » de 1955, doit résoudre les paradoxes temporels provoqués par ses interventions dans le passé, et trouver le moyen de faire fonctionner la machine pour retourner à son époque d'origine.",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/916W6HeeyzL.jpg",
                    Price = 9.99m,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 2,
                    Title = "Benoît Poelvoorde",
                    Description = "Benoît Poelvoorde (/bə.nwa pul.vɔʁd/), né le 22 septembre 1964 à Namur, est un acteur et humoriste belge.Révélé durant les années 1990 par le film culte belge C'est arrivé près de chez vous (1992), la série humoristique Les Carnets de Monsieur Manatane (1997), il est la vedette de la comédie française Les Randonneurs (1997), qui fait plus de 1,5 millions d'entrées au cinéma.Il s'impose ensuite durant les années 2000 comme une valeur sûre du cinéma franco-belge.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f8/Benoit_Poelvoorde_Cabourg_2018.jpg/220px-Benoit_Poelvoorde_Cabourg_2018.jpg",
                    Price = 7.99m,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 3,
                    Title = "Ready Player One (film)",
                    Description = "En 2045, le monde est en proie à de nombreux soucis : crise énergétique, désastres causés par le changement climatique, la famine, la pauvreté, la guerre, etc. Dans ce monde chaotique, l'Oasis est un système mondial de réalité virtuelle, accessible par l'intermédiaire de casques de réalité virtuelle et de dispositifs haptiques tels que des gants et des combinaisons. Conçu à l'origine comme un MMORPG, il est devenu au fil du temps une société virtuelle dont toute l'humanité se sert comme exutoire.",
                    ImageUrl = "https://fr.web.img4.acsta.net/pictures/18/02/14/09/15/3437390.jpg",
                    Price = 15.99m,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 4,
                    Title = "La Reine du Sud",
                    Description = "La Reine du sud (La Reina del sur) est une telenovela américano-espagnole-colombienne.La première saison a été diffusée entre le 28 février 2011 et le 30 mai 2011 sur Telemundo aux États-Unis et à partir du 14 mars 2011 sur Antena 3 en Espagne.La deuxième saison a été diffusée entre le 22 avril 2019 et le 29 juillet 2019 sur Telemundo aux États-Unis.En France, la première saison a été diffusée à partir du 29 février 2012 sur France Ô1, puis disponible depuis l'automne 2016 sur 6play2 ; et au Québec à partir du 31 décembre 2012 sur Séries+.Le 11 mai 2017, Telemundo confirme que La Reine du sud est renouvelée pour une deuxième saison[réf. souhaitée] dont la diffusion était prévue pour l'année 2019 aux États-Unis.Le 16 juillet 2020, Kate del Castillo et la chaine Telemundo annonce que La Reine du sud est renouvelée pour une troisième saison dont la diffusion est prévue pour 2021 - 2022 aux États-Unis.",
                    ImageUrl = "https://fr.web.img6.acsta.net/pictures/16/04/19/11/23/421985.jpg",
                    Price = 5.99m,
                    CategoryId = 2
                },
             
                new Product
                {
                    Id = 5,
                    CategoryId = 2,
                    Price = 3.99m,
                    Title = "Back to the Future",
                    Description = "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg",
                },
                new Product
                {
                    Id = 6,
                    CategoryId = 2,
                    Price = 2.99m,
                    Title = "Toy Story",
                    Description = "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg",

                },
                new Product
                {
                    Id = 7,
                    CategoryId = 3,
                    Title = "Half-Life 2",
                    Price = 49.99m,
                    Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",

                },
                new Product
                {
                    Id = 8,
                    CategoryId = 3,
                    Title = "Diablo II",
                    Price = 9.99m,
                    Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                },
                new Product
                {
                    Id = 9,
                    CategoryId = 3,
                    Price = 14.99m,
                    Title = "Day of the Tentacle",
                    Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",
                },
                new Product
                {
                    Id = 10,
                    CategoryId = 3,
                    Price = 159.99m,
                    Title = "Xbox",
                    Description = "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
                },
                new Product
                {
                    Id = 11,
                    CategoryId = 3,
                    Price = 79.99m,
                    Title = "Super Nintendo Entertainment System",
                    Description = "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                },
                 new Product
                 {
                     Id = 12,
                     CategoryId = 2,
                     Price = 4.99m,
                     Title = "The Matrix",
                     Description = "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.",
                     ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg",
                 }
                );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
