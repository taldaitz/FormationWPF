using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo02
{
    class Contact
    {
        public String prenom;
        public String Nom;
        public DateTime? dateNaissance;
        public bool? actif;
        public List<String> roles;

        public Contact(string prenom, string nom, DateTime? dateNaissance, bool? actif, List<string> roles)
        {
            this.prenom = prenom;
            Nom = nom;
            this.dateNaissance = dateNaissance;
            this.actif = actif;
            this.roles = roles;
        }
    }
}
