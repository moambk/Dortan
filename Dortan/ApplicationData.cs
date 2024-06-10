
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

namespace Dortan
{

    public class ApplicationData
    {

        private static ObservableCollection<Activite> lesActivites = new ObservableCollection<Activite>();
        private static ObservableCollection<Materiel> lesMateriels = new ObservableCollection<Materiel>();
        private static ObservableCollection<Employe> lesEmployes = new ObservableCollection<Employe>();
        private NpgsqlConnection connexion = null;   // futur lien à la BD

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
            string sql = "SELECT num_activite, nom_activite FROM activite ac" +
                "join ";

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
        public bool TryConnexion(Employe connexion)
        {

            string sql = $"Host=localhost;Username={connexion.Identifiant};Password={connexion.Password};Database=caca sae";
            string sql2 = $"Server=srv-peda-new; port=5433; "
                + $"Database=SAE2.01 Dortan;Search Path=Dortan;uid={connexion.Identifiant};password={connexion.Password};";
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