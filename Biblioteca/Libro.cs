﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Libro(string autore,string titolo, int annoPubblicazione, string editore, int numeroPagine)
    {
        string autore = autore;
        string titolo = titolo; 
        int annoPubblicazione = annoPubblicazione;
        string editore = editore;
        int numeroPagine = numeroPagine;

        public string toString()
        {
            string stringa;
            return stringa = $"{autore}, {titolo}, {annoPubblicazione}, {editore}, {numeroPagine}";
        }
        public int readingTime(int numeroPagine)
        {
            if (numeroPagine < 100)
            {
                return 1;
            }
            else if (numeroPagine > 100 && numeroPagine < 200)
            {
                return 2;
            }
            else return 3;
            
        }
    }
}
