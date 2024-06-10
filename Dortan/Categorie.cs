using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dortan
{
    internal class Categorie
    {
        private string nomCategorie;

        public Categorie()
        {
        }

        public Categorie(string nomCategorie)
        {
            NomCategorie = nomCategorie;
        }

        public string NomCategorie { get => nomCategorie; set => nomCategorie = value; }
    }
}
