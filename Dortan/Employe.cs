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
			set {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("mot de passe doit etre renseigné");
                if (value.Length > 20)
                    throw new ArgumentException("login trop long");
                this.password = value; }
		}


		public string Identifiant
		{
			get { return this.identifiant; }
			set {
				if (string.IsNullOrEmpty(value))
					throw new ArgumentNullException("login doit etre renseigné");
				if (value.Length > 8)
					throw new ArgumentException("login trop long");
				this.identifiant = value; }
		}

        public Employe(string password, string identifiant)
        {
            this.Password = password;
            this.Identifiant = identifiant;
        }
		public Employe() { }
    }


}
