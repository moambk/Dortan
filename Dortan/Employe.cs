using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dortan
{
    public class Employe
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

        public Employe(string password, string identifiant)
        {
            this.Password = password;
            this.Identifiant = identifiant;
        }
		public Employe() { }
    }


}
