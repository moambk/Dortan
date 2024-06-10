using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dortan
{
    internal class TypeMateriel
    {
        private int numType;
        private string nomType;

        public TypeMateriel()
        {
        }

        public TypeMateriel(int numType, string nomType)
        {
            NumType = numType;
            NomType = nomType;
        }

        public int NumType { get => numType; set => numType = value; }
        public string NomType { get => nomType; set => nomType = value; }
    }
}
