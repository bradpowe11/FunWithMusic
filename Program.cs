namespace FunWithMusic
{
    class Program
    {
        enum Genre
        {
            Blues,
            Rock,
            Pop,
            EDM,
            Country
        }
        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private string Length;
            private Genre? Genre;

            public Music(string title, string artist, string album, string length, Genre genre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                Genre = genre;
            }
            public void setTitle(string title)
            {
                Title = title;
            }
            public void setLenght(string length)
            {
                Length = length;
            }
            public string Display()
            {
                return "Title: " + Title + "\nArtist: " + Artist +
                    "\nAlbum: " + Album + "\nLength: " + Length + "\nGenre: " + Genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is the title of your favorite song?");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Who is the artist?");
            string tempArtist = Console.ReadLine();
            Console.WriteLine("What is the name of the album?");
            string tempAlbum = Console.ReadLine();
            Console.WriteLine("Whath is the length of the song?");
            string tempLength = Console.ReadLine();
            Console.WriteLine("What is the genre?");
            Console.WriteLine("B - Blues\nR - Rock\nP - Pop\nE - EDM \nC - Country");
            Genre tempGenre = Genre.Blues;
            char g = char.Parse(Console.ReadLine());
            switch (g)
            {
                case 'B':
                    tempGenre = Genre.Blues;
                    break;
                case 'R':
                    tempGenre = Genre.Rock;
                    break;
                case 'P':
                    tempGenre = Genre.Pop;
                    break;
                case 'E':
                    tempGenre = Genre.EDM;
                    break;
                case 'C':
                    tempGenre = Genre.Country;
                    break;
            }
            Music music = new Music(tempTitle, tempArtist, tempAlbum, tempLength, tempGenre);
            Music newMusic = music;
            newMusic.setTitle("The wheels on the bus");
            newMusic.setLenght("5");
            Console.WriteLine("Here's song #2");
            Console.WriteLine($"{newMusic.Display()}");
            Console.WriteLine();
            Console.WriteLine("Here's song #1");
            Console.WriteLine($"{music.Display()}");

        }
    }
}
