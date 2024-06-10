using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dortan
{
    internal class Concerne
    {
        private Reservation uneReservation;
        private Materiel unMateriel;

        public Concerne()
        {
        }

        public Concerne(Reservation uneReservation, Materiel unMateriel)
        {
            UneReservation = uneReservation;
            UnMateriel = unMateriel;
        }

        public Reservation UneReservation { get => uneReservation; set => uneReservation = value; }
        public Materiel UnMateriel { get => unMateriel; set => unMateriel = value; }
    }
}
