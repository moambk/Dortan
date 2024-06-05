
using Npgsql;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dortan
{

        public class ApplicationData
        {
       
            private ObservableCollection<Agent> lesAgents;
            private NpgsqlConnection connexion = null;   // futur lien à la BD


        public ObservableCollection<Agent> LesAgents
        {
            get
            {
                return this.lesAgents;
            }

            set
            {
                this.lesAgents = value;
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
             this.LesAgents = new ObservableCollection<Agent>();
            }
        
        }
    
}
