using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dortan
{
    internal class Site
    {
        private int numSite;
        private string nomSite;
        private string adresseRue;
        private string nomResponsable;
        private string horaire;

        public Site()
        {
        }

        public Site(int numSite, string nomSite, string adresseRue, string nomResponsable, string horaire)
        {
            NumSite = numSite;
            NomSite = nomSite;
            AdresseRue = adresseRue;
            NomResponsable = nomResponsable;
            Horaire = horaire;
        }

        public int NumSite { get => numSite; set => numSite = value; }
        public string NomSite { get => nomSite; set => nomSite = value; }
        public string AdresseRue { get => adresseRue; set => adresseRue = value; }
        public string NomResponsable { get => nomResponsable; set => nomResponsable = value; }
        public string Horaire { get => horaire; set => horaire = value; }
    }
}
