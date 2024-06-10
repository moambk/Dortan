using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dortan
{
    internal class Reservation
    {
        private int numReservation;
        private DateTime dateReservation;
        private int dureeReservation;
        private Activite uneActivite;
        public int NumReservation { get => numReservation; set => numReservation = value; }
        public DateTime DateReservation { get => dateReservation; set => dateReservation = value; }
        public int DureeReservation { get => dureeReservation; set => dureeReservation = value; }
        public Activite UneActivite { get => uneActivite; set => uneActivite = value; }

        public Reservation()
        {
        }

        public Reservation(int numReservation, DateTime dateReservation, int dureeReservation, Activite uneActivite)
        {
            NumReservation = numReservation;
            DateReservation = dateReservation;
            DureeReservation = dureeReservation;
            UneActivite = uneActivite;
        }


    }
}
