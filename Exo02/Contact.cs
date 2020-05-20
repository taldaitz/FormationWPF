using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo02
{
    class Contact
    {
        public String Prenom { get; set; }
        public String Nom { get; set; }
        public DateTime? DateNaissance { get; set; }
        public bool? Actif { get; set; }
        public String Email { get; set; }
        public List<String> Roles { get; set; }

        public bool IsEmailValid
        {
            get
            {
                return Email.Contains("@");
            }
        }

        public Contact(string prenom, string nom, string email, DateTime? dateNaissance, bool? actif, List<string> roles)
        {
            this.Prenom = prenom;
            Nom = nom;
            this.DateNaissance = dateNaissance;
            this.Actif = actif;
            this.Roles = roles;
            this.Email = email;
        }
    }
}
