using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo02
{
    class ContactManager
    {
        public static void creerContact(string prenom, string nom, string email, DateTime? dateNaissance, 
            bool? actif, List<String> roles)
        {
            using (StreamWriter writer = new StreamWriter("contacts.csv", true))
            {
                writer.WriteLine("{0};{1};{2};{3};{4};{5}",
                        prenom,
                        nom,
                        email,
                        dateNaissance.ToString(),
                        actif.ToString(),
                        String.Join("|", roles)
                    );
            }
        }

        public static List<Contact> chargerContacts()
        {
            List<Contact> contacts = new List<Contact>();

            using (StreamReader reader= new StreamReader("contacts.csv"))
            {
                while (!reader.EndOfStream) {
                    String[] line = reader.ReadLine().Split(';');

                    Contact contact = new Contact(line[0], line[1], line[2],
                                                    DateTime.Parse(line[3]),
                                                    line[4] == "True" ? true : false,
                                                    line[5].Split('|').ToList()
                                                    );

                    contacts.Add(contact);
                }
            }


            return contacts;
        }

    }
}
