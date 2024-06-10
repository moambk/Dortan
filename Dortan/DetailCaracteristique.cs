using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dortan
{
    internal class DetailCaracteristique
    {
        private Materiel unMateriel;
        private Caracteristique uneCaracteristique;
        private string valeurCaracteristique;
        public Materiel UnMateriel { get => unMateriel; set => unMateriel = value; }
        public Caracteristique UneCaracteristique { get => uneCaracteristique; set => uneCaracteristique = value; }
        public string ValeurCaracteristique { get => valeurCaracteristique; set => valeurCaracteristique = value; }

        public DetailCaracteristique()
        {
        }

        public DetailCaracteristique(Materiel unMateriel, Caracteristique uneCaracteristique, string valeurCaracteristique)
        {
            UnMateriel = unMateriel;
            UneCaracteristique = uneCaracteristique;
            ValeurCaracteristique = valeurCaracteristique;
        }

        
    }
}
