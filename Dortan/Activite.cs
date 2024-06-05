using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dortan
{
    public class Activite
    {
        private string nom;

        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }

        public Activite(string nom)
        {
            this.Nom = nom;
        }
    }
}
