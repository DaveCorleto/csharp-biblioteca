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
        public DateTime InizioPrestito;
        public DateTime FinePrestito;
        public Utente Beneficiario;
        public Documenti Prestato;

        // Liste per gli utenti, i libri e i DVD
        public List<Utente> Utenti { get; } = new List<Utente>();
        public List<Libro> Libri { get; } = new List<Libro>();
        public List<Dvd> Dvd { get; } = new List<Dvd>();

        public Biblioteca(DateTime inizioPrestito, DateTime finePrestito, Utente beneficiario, Documenti prestato, List<Utente> utenti, List<Libro> libri, List<Dvd> dvd)
        {
            InizioPrestito = inizioPrestito;
            FinePrestito = finePrestito;
            Beneficiario = beneficiario;
            Prestato = prestato;
            Utenti = utenti;
            Libri = libri;
            Dvd = dvd;
        }

        // Metodo per aggiungere un utente alla lista degli utenti
        public void AggiungiUtente(Utente utente)
        {
            Utenti.Add(utente);
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
