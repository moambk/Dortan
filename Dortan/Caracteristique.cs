using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dortan
{
    internal class Caracteristique
    {
        private int numCaracteristique;
        private string nomCaracteristique;

        public Caracteristique()
        {
        }

        public Caracteristique(int numCaracteristique, string nomCaracteristique)
        {
            NumCaracteristique = numCaracteristique;
            NomCaracteristique = nomCaracteristique;
        }

        public int NumCaracteristique { get => numCaracteristique; set => numCaracteristique = value; }
        public string NomCaracteristique { get => nomCaracteristique; set => nomCaracteristique = value; }
    }

}

