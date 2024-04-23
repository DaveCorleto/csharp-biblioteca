using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    using System;
    using System.Collections.Generic;

    public class Biblioteca
    {

        //Creazione del dizionario per i documenti: contiene sia dvd che Libri
        public Dictionary<string, Documenti> ArchivioDocumenti { get; set; } = new();

        //Creo una lista di Utenti 
        public List<Utente> ListaUtenti { get; set; } = new();

        //Creo una lista di Prestiti 
        public List<Prestito> ListaPrestiti {  get; set; } = new();


        public Biblioteca()
        {

        }

        // Metodo per aggiungere un utente alla lista degli utenti
        public void AggiungiUtente(Utente utente)
        {
            Utenti.Add(utente);
        }

    }

    public class Prestito
    
        //public DateTime InizioPrestito;
        //public DateTime FinePrestito;
        //public Utente Beneficiario;
        //public Documenti Prestato;
    
    {
        public string IdDocumentoPresoInPrestito { get; set; }
        public Utente UtenteBeneficiario { get; set; }
        public DateTime PrestitoInizio { get; set; }
        public DateTime PrestitoFine { get; set; }

        public Prestito(string idDocumentoPresoInPrestito, Utente u, DateTime prestitoInizio, DateTime prestitoFine)
        {
            IdDocumentoPresoInPrestito = idDocumentoPresoInPrestito;
            UtenteBeneficiario = new Utente(u.Nome, u.Cognome, u.Email, u.Password, u.RecapitoTelefonico);
            PrestitoInizio = prestitoInizio;
            PrestitoFine = prestitoFine;
        }

        public override string ToString()
        {
            return $"Codice doc {IdDocumentoPresoInPrestito}> Utente {UtenteBeneficiario?.ToString()} -- Da {PrestitoInizio} a {PrestitoFine}";
        }
    }

    public class Utente
    {
        public string Cognome;
        public string Nome;
        public string Email;
        public string Password;
        public string RecapitoTelefonico;

        public Utente(string cognome, string nome, string email, string password, string recapitoTelefonico)
        {
            Cognome = cognome;
            Nome = nome;
            Email = email;
            Password = password;
            RecapitoTelefonico = recapitoTelefonico;
        }
    }

    public class Documenti
    {
        public int ISBN;
        public string Titolo;
        public string Anno;
        public string Settore;
        public string Scaffale;
        public string Autore;

        public Documenti(int isbn, string titolo, string anno, string settore, string scaffale, string autore)
        {
            ISBN = isbn;
            Titolo = titolo;
            Anno = anno;
            Settore = settore;
            Scaffale = scaffale;
            Autore = autore;
        }
    }

    public class Dvd : Documenti
    {
        public int Durata;

        public Dvd(int isbn, string titolo, string anno, string settore, string scaffale, string autore, int durata)
            : base(isbn, titolo, anno, settore, scaffale, autore)
        {
            Durata = durata;
        }
    }

    public class Libro : Documenti
    {
        public int NumeroPagine;

        public Libro(int isbn, string titolo, string anno, string settore, string scaffale, string autore, int numeroPagine)
            : base(isbn, titolo, anno, settore, scaffale, autore)
        {
            NumeroPagine = numeroPagine;
        }
    }
 }
