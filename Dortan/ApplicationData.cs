
using Npgsql;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

            private ObservableCollection<Activite> lesActivites = new ObservableCollection<Activite>();
            private ObservableCollection<Materiel> lesMateriels = new ObservableCollection<Materiel>();
            private ObservableCollection<Employe> lesEmployes = new ObservableCollection<Employe>();
            private NpgsqlConnection connexion = null;   // futur lien à la BD

        public ObservableCollection<Employe> LesEmployes
        {
            get
            {
                return this.lesEmployes;
            }

            set
            {
                this.lesEmployes = value;
            }
        }
        public ObservableCollection<Materiel> LesMateriels
        {
            get
            {
                return this.lesMateriels;
            }

            set
            {
                this.lesMateriels = value;
            }
        }
        public ObservableCollection<Activite> LesActivites
        {
            get
            {
                return this.lesActivites;
            }

            set
            {
                this.lesActivites = value;
            }
        }

       public NpgsqlConnection Connexion 
        {
            get
            {
                return this.connexion ;
            }

            set
            {
                this.connexion  = value;
            }
        }
       
	   public ApplicationData()
        {
           
        }
        
        public void Read()
            {
                
            }
        public void TryConnexion(Employe Connexion)
        {
            String sql = $"Server=srv-peda-new; port=5433; "
                + $"Database=SAE2.01 Dortan;Search Path=Dortan;uid={Connexion.Identifiant};mpd={Connexion.Password};";
            if (DataAccess.Instance.ConnexionBD(sql))
                MessageBox.Show("probleme connexion");


        }

    }
    
}
