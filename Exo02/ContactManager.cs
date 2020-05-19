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
        public static void creerContact(string prenom, string nom, DateTime? dateNaissance, 
            bool? actif, List<String> roles)
        {
            using (StreamWriter writer = new StreamWriter("contacts.csv", true))
            {
                writer.WriteLine("{0};{1};{2};{3};{4}",
                        prenom,
                        nom,
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

                    Contact contact = new Contact(line[0], line[1],
                                                    DateTime.Parse(line[2]),
                                                    line[3] == "True" ? true : false,
                                                    line[4].Split('|').ToList()
                                                    );

                    contacts.Add(contact);
                }
            }


            return contacts;
        }

    }
}
