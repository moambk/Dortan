
using Npgsql;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dortan
{

        public class ApplicationData
    {

            private ObservableCollection<Activite> LesActivites;
            private NpgsqlConnection connexion = null;   // futur lien à la BD


        public ObservableCollection<Activite> lesActivites
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
           
            this.ConnexionBD();
            this.Read();
        }
        public void ConnexionBD()
            {

            try { 
                Connexion = new NpgsqlConnection();
                Connexion.ConnectionString = 
                    "Server=srv-peda-new;" + 
                    "port=5433;" +
                    "Database=SAE2.01;" +
                    "Search Path = Dortan;" +
                    "uid=bekhoucm;" +
                    "password=vadzM7;";
                }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            }
        public void Read()
            {
             this.lesActivites = new ObservableCollection<Activite>();
            }
        
        }
    
}
