
using Npgsql;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Dortan
{

    public class ApplicationData
    {

        private static ObservableCollection<Activite> lesActivites = new ObservableCollection<Activite>();
        private static ObservableCollection<Materiel> lesMateriels = new ObservableCollection<Materiel>();
        private static ObservableCollection<Employe> lesEmployes = new ObservableCollection<Employe>();
        private static ObservableCollection<Categorie> lesCategories = new ObservableCollection<Categorie>();
        private static ObservableCollection<TypeMateriel> lesTypes = new ObservableCollection<TypeMateriel>();
        private static ObservableCollection<Site> lesSites = new ObservableCollection<Site>();
        private static ObservableCollection<Reservation> lesReservations = new ObservableCollection<Reservation>();
        private static ObservableCollection<Concerne> lesConcernes = new ObservableCollection<Concerne>();
        private static ObservableCollection<Caracteristique> lesCaracteristiques = new ObservableCollection<Caracteristique>();
        private static ObservableCollection<DetailCaracteristique> lesDetailCaracteristiques = new ObservableCollection<DetailCaracteristique>();

        private NpgsqlConnection connexion = null;   // futur lien à la BD

      
        /*public static ObservableCollection<Categorie> LesCategories { get => lesCategories; set => lesCategories = value; }
        public static ObservableCollection<TypeMateriel> LesTypes { get => lesTypes; set => lesTypes = value; }
        public static ObservableCollection<Site> LesSites { get => lesSites; set => lesSites = value; }
        public static ObservableCollection<Reservation> LesReservations { get => lesReservations; set => lesReservations = value; }
        public static ObservableCollection<Concerne> LesConcernes { get => lesConcernes; set => lesConcernes = value; }
        public static ObservableCollection<Caracteristique> LesCaracteristiques { get => lesCaracteristiques; set => lesCaracteristiques = value; }
        public static ObservableCollection<DetailCaracteristique> LesDetailCaracteristiques { get => lesDetailCaracteristiques; set => lesDetailCaracteristiques = value; }*/
        public static ObservableCollection<Activite> LesActivites  { get => lesActivites; set => lesActivites = value; }
        public static ObservableCollection<Materiel> LesMateriels { get => lesMateriels; set => lesMateriels = value; }
        public static ObservableCollection<Employe> LesEmployes { get => lesEmployes; set => lesEmployes = value; }

        public NpgsqlConnection Connexion
        {
            get
            {
                return this.connexion;
            }

            set
            {
                this.connexion = value;
            }
        }

        public ApplicationData()
        {

        }

        public void Read()
        {
            string sql = "SELECT num_activite, nom_activite FROM activite";

            try
            {


                foreach (DataRow res in DataAccess.Instance.GetData(sql).Rows)
                {
                    Activite nouveau = new Activite(int.Parse(res["num_activite"].ToString()), res["nom_activite"].ToString());
                    LesActivites.Add(nouveau);
                    foreach (Activite cca in LesActivites)
                    {
                        Console.WriteLine(cca.ToString());
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ReadVisu()
        {
            string sql = "select * from mreservation";
            try
            {
                foreach (DataRow res in DataAccess.Instance.GetData(sql).Rows)
                {
                    Reservation nouveau = new Reservation(int.Parse(res["num_reservation"].ToString()), DateTime.Parse(res["date_reservation"].ToString()), int.Parse(res["duree_reservation"].ToString()), LesActivites[int.Parse(res["num_activite"].ToString())]);
                    //LesReservations.Add(nouveau);
                    Console.WriteLine(nouveau.NumReservation.ToString() + nouveau.UneActivite.Num_activite.ToString() + nouveau.DateReservation.ToString() + nouveau.DureeReservation.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            public bool TryConnexion(Employe connexion)
        {

            string sql2 = $"Host=localhost;Username={connexion.Identifiant};Password={connexion.Password};Database=caca sae";
            string sql = $"Server=srv-peda-new; port=5433; "
                + $"Database=sae2.01_dortan;Search Path=dortan;uid={connexion.Identifiant};password={connexion.Password};";
            if (DataAccess.Instance.ConnexionBD(sql))
            {
                MessageBox.Show("probleme connexion");
                return false;
            }
            else
            {

                return true;
            }
    }


}

}