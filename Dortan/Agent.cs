using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dortan
{
    class Agent
    {
		private string identifiant;
		private string password;

		public string Password
		{
			get { return this.password; }
			set { this.password = value; }
		}


		public string Identifiant
		{
			get { return this.identifiant; }
			set { this.identifiant = value; }
		}

        public Agent(string password, string identifiant)
        {
            this.Password = password;
            this.Identifiant = identifiant;
        }
    }


}
