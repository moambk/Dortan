using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dortan
{
    public class Activite
    {
        private int num_activite;
        private string nom_activite;

        public string Nom_activite
        {
            get { return this.nom_activite; }
            set
            {
                if (string.IsNullOrEmpty(value)) { throw new ArgumentException("tous les champs doivent être remplis !"); }
                else { this.nom_activite = value; }
                if (value.Length > 100) { throw new ArgumentException("Nom de l'activité trop long"); }
                else { this.nom_activite = value; }
            }
        }


        public int Num_activite
        {
            get { return this.num_activite; }
            set { this.num_activite = value; }
        }

        public Activite()
        {
        }

       
        public Activite(int num_activite,string nom_activite)
        {
            this.Nom_activite = nom_activite;
            this.Num_activite = num_activite;
        }

        public override string? ToString()
        {
            return $"NUM ACTIVTE : {Num_activite} " +
                   $"|| NOM ACTIVTE : {Nom_activite} ";
        }
    }
}
