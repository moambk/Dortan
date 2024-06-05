
using Npgsql;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_BD_Locale
{

        public class ApplicationData
        {
       
            private ObservableCollection<Agent> lesClients;
            private NpgsqlConnection connexion = null;   // futur lien à la BD


        public ObservableCollection<Client> LesClients
        {
            get
            {
                return this.lesClients;
            }

            set
            {
                this.lesClients = value;
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
            
            }
        public void Read()
            {
             this.LesClients = new ObservableCollection<Client>();
            }
        
        }
    
}
