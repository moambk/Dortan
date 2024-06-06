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
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("mot de passe doit etre renseigné");
                else { this.password = value; }
                if (value.Length > 20) throw new ArgumentException("le mot de passe est trop long");
				else { this.password = value; }
			}
		}


		public string Identifiant
		{
			get { return this.identifiant; }
			set {
				if (string.IsNullOrEmpty(value)) {throw new ArgumentNullException("le login doit etre renseigné"); }
				else { this.identifiant = value; }
				if (value.Length > 8) { throw new ArgumentException("le login est trop long"); }
				else { this.identifiant = value; }
			}
		}

        public Employe(string password, string identifiant)
        {
            this.Password = password;
            this.Identifiant = identifiant;
        }
		public Employe() { }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }


}
