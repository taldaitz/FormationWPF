using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo05
{
    class Customer
    {
        public String Nom { get; set; }
        public String Prenom { get; set; }
        public String Email { get; set; }
        public int Age { get; set; }

        public bool IsEmailValid
        {
            get
            {
                return Email.Contains("@");
            }
        }
    }
}
