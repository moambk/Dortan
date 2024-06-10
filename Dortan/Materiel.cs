using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dortan
{
    public class Materiel
    {
		private int num_materiel;
		private string nom_categorie;
		private int num_site;
		private string nom_materiel;
		private string marque;
		private double puissance_cv;
		private int puissance_w;
		private double cout_utilisation;

		public double Cout_utilisation
		{
			get { return cout_utilisation; }
			set { cout_utilisation = value; }
		}


		public int Puissance_w
		{
			get { return puissance_w; }
			set { puissance_w = value; }
		}

		public double Puissance_cv
		{
			get { return puissance_cv; }
			set { puissance_cv = value; }
		}

		public string Marque
		{
			get { return marque; }
			set { marque = value; }
		}

		public string Nom_materiel
		{
			get { return nom_materiel; }
			set { nom_materiel = value; }
		}

		public int Num_site
		{
			get { return num_site; }
			set { num_site = value; }
		}

		public string Nom_categorie
		{
			get { return nom_categorie; }
			set { nom_categorie = value; }
		}

		public int Num_materiel
		{
			get { return num_materiel; }
			set { num_materiel = value; }
		}

        public Materiel()
        {
        }
    }
}
