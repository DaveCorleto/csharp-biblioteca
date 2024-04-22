using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Biblioteca
    {

        public List<Utente> Utenti { get; } = new List<Utente>();
        public void AggiungiUtente(Utente utente)
        {
            Utenti.Add(utente);
        }
        // Costruttore vuoto di Biblioteca da richiamare in tutte le classi figlie
        public Biblioteca() { }
    }

    //public class Prestito : Biblioteca {

    //    public DateTime inizioPrestito;
    //    public DateTime finePrestito;
    //    private Utente beneficiario;
    //    private Documenti documentoPrestato;
       

    //    public Utente Beneficiario
    //    {
    //        get { return beneficiario; } 
    //        set { beneficiario = value; }
    //    }

    //    public Documenti DocumentoPrestato
    //    {
    //        get { return documentoPrestato; }
    //        set { documentoPrestato = value; }
    //    }


    //    public Prestito() :base(){ 
    //        this.inizioPrestito = DateTime.Now;
    //        this.finePrestito = inizioPrestito.AddDays(3);

    //    }
    //}


    public class Utente
    {
        public string cognome;
        public string nome;
        public string email;
        public string password;
        public string recapitoTelefonico;
        public Utente(string cognome, string nome, string email, string password, string recapitoTelefonico) : base()
             // Chiamata al costruttore senza parametri della classe base
        {
            this.cognome = cognome;
            this.nome = nome;
            this.email = email;
            this.password = password;
            this.recapitoTelefonico = recapitoTelefonico;
        }
        //metodo prendi in prestito documento (Libro o dvd)
    }

    public class Documenti
    {
        public int ISBN;
        public string titolo;
        public string anno;
        public string settore;
        public string scaffale;
        public string autore; 

        public Documenti(int ISBN, string titolo, string anno, string settore, string scaffale, string autore) :base(){

            Random code = new Random();   

            this.ISBN = code.Next(100000,999999);
            this.titolo = titolo;
            this.anno = anno;
            this.settore = settore;
            this.scaffale = scaffale;
            this.autore = autore;
        }

    }

    public class Dvd : Documenti
    {
        public int durata;

        public Dvd(int ISBN, string titolo, string anno, string settore, string scaffale, string autore, int durata)
        : base(ISBN, titolo, anno, settore, scaffale, autore)
        {
            this.durata = durata;
        }

    }
    public class Libro : Documenti
    {
        public int numeroPagine;
        public Libro (int ISBN, string titolo, string anno, string settore, string scaffale, string autore, int numeroPagine)
        : base(ISBN, titolo, anno, settore, scaffale, autore)
        {
            this.numeroPagine = numeroPagine;
        }
    }

}
