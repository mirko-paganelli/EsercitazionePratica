using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Biblioteca(string nome, string indirizzo, string orarioApertura, string orarioChiusura, List<Libro> elencoLibri)
    {
        string nome = nome;
        string indirizzo = indirizzo;
        string orarioApertura = orarioApertura;
        string orarioChiusura = orarioChiusura;
        List <Libro> elencoLibri = elencoLibri;

        public bool CercaLibroTitolo() 
        {
            return false;//TODO
        }
        public bool CercaLibriAutore()
        {
            return false;//TODO
        }


    }
}
