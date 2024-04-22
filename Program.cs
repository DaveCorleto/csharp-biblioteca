namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creazione Utenti

            Utente JohnTravolta = new Utente("Travolta", "John", "john.travolta@example.com", "password123", "3912356789");
            Utente MarioRossi = new Utente("Rossi", "Mario", "mario.rossi@example.com", "password123", "3912356789");
            Utente LauraBianchi = new Utente("Bianchi", "Laura", "laura.bianchi@example.com", "qwerty456", "39987654321");
            Utente SarahSmith = new Utente("Smith", "Sarah", "sarah.smith@example.com", "sarah123", "447890123456");
            Utente MarcoGialli = new Utente("Gialli", "Marco", "marco.gialli@example.com", "marco456", "39333987654");
            Utente AnnaJohnson = new Utente("Johnson", "Anna", "anna.johnson@example.com", "anna789", "441234567890");
            Utente EmmaWhite = new Utente("White", "Emma", "emma.white@example.com", "emma345", "393339876543");
            Utente LucaVerdi = new Utente("Verdi", "Luca", "luca.verdi@example.com", "luca678", "393383838383");
            Utente SofiaBrown = new Utente("Brown", "Sofia", "sofia.brown@example.com", "sofia123", "441234567890");
            Utente MichaelGray = new Utente("Gray", "Michael", "michael.gray@example.com", "michael456", "447890123456");

            //Creazione Libri 

            Libro ilNomeDelVento = new Libro(1234567890, "Il nome del vento", "2007", "Fantasy", "A3", "Patrick Rothfuss", 662);
            Libro milleSplendidiSoli = new Libro(46546579, "Mille Splendidi Soli", "2002", "Tragico", "B1", "Khaled Hosseini", 450);
            Libro ilSignoreDegliAnelli = new Libro(97888452, "Il Signore degli Anelli", "1954", "Fantasy", "A2", "J.R.R. Tolkien", 1216);
            Libro harryPotter = new Libro(97832743, "Harry Potter e la Pietra Filosofale", "1997", "Fantasy", "A1", "J.K. Rowling", 336);
            Libro cronicheDelGhiaccioEldu = new Libro(97843433, "Le Cronache del Ghiaccio e del Fuoco", "1996", "Fantasy", "C2", "George R.R. Martin", 547);
            Libro ilCodiceDaVinci = new Libro(978140179, "Il Codice da Vinci", "2003", "Thriller", "D1", "Dan Brown", 592);
            Libro orgoglioEPregiudizio = new Libro(978019518, "Orgoglio e Pregiudizio", "1813", "Romanzo", "B3", "Jane Austen", 432);
            Libro centoAnniDiSolitudine = new Libro(97880419, "Cento anni di solitudine", "1967", "Romanzo", "C1", "Gabriel García Márquez", 432);

            //Creazione Dvd 

            Dvd titanic = new Dvd(616546126, "Titanic", "1997", "Classico", "A6", "Non me lo ricordo", 150);
            Dvd inception = new Dvd(50578841, "Inception", "2010", "Thriller", "B4", "Christopher Nolan", 148);
            Dvd loHobbit = new Dvd(50546959, "Lo Hobbit", "2001", "Fantasy", "A2", "Peter Jackson", 178);
            Dvd matrix = new Dvd(73219443, "Matrix", "1999", "Sci-Fi", "B1", "Lana Wachowski", 136);
            Dvd forrestGump = new Dvd(505092714, "Forrest Gump", "1994", "Drammatico", "C3", "Robert Zemeckis", 142);
            Dvd ilPianista = new Dvd(505058220, "Il Pianista", "2002", "Drammatico", "D2", "Roman Polanski", 150);
            Dvd fightClub = new Dvd(80235089, "Fight Club", "1999", "Drammatico", "C1", "David Fincher", 139);
            Dvd pulpFiction = new Dvd(871741912, "Pulp Fiction", "1994", "Crime", "B2", "Quentin Tarantino", 154);
            Dvd schindlersList = new Dvd(505004632, "Schindler's List", "1993", "Drammatico", "D3", "Steven Spielberg", 195);
            Dvd theShawshankRedemption = new Dvd(732191869, "The Shawshank Redemption", "1994", "Drammatico", "A5", "Frank Darabont", 142);


        }
    }
}
