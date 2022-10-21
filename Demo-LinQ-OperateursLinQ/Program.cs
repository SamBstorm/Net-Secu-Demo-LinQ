using System.Collections;

namespace Demo_LinQ_OperateursLinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arraylist_contacts = new ArrayList() {
                new Contact() { Email ="delphine@tftic.be", FirstName = "Delphine", LastName= "Vander Stricht", BirthDateYear = 2000 },
                new Contact() { Email ="michel@tftic.be", FirstName = "Michel", LastName= "Clarot", BirthDateYear = 2000 },
                new Contact() { Email ="paul@tftic.be", FirstName = "Paul", LastName= "Bottemanne", BirthDateYear = 1990 },
                new Contact() { Email ="benjamin@tftic.be", FirstName = "Benjamin", LastName= "Stercks", BirthDateYear = 1990 },
                new Contact() { Email ="jean@tftic.be", FirstName = "Jean", LastName= "Timmermans", BirthDateYear = 1990 },
                new Contact() { Email ="thomas@tftic.be", FirstName = "Thomas", LastName= "Ayissi", BirthDateYear = 2000 },
                new Contact() { Email ="jeremie@tftic.be", FirstName = "Jeremie", LastName= "Lopopola", BirthDateYear = 1940 },
                new Contact() { Email ="seif@tftic.be", FirstName = "Seif", LastName= "Meddeb", BirthDateYear = 1990 },
                new { Email = "samuel@form.tftic.be", LastName = "Legrain" },
                new Contact() { Email ="ryan@tftic.be", FirstName = "Ryan", LastName= "Costache", BirthDateYear = 2000 },
                new Contact() { Email ="yves@tftic.be", FirstName = "Yves", LastName= "Tshitamba", BirthDateYear = 2000 }
            };

            var first_contact = arraylist_contacts[0]; //ArrayList => List<object> ... Pas top pour nos class...

            //IEnumerable<Contact> contacts = arraylist_contacts.Cast<Contact>(); //conversion d'object en Contact!
            //Cast<T>() crash si un objet non-compatible se trouve dans la liste à caster

            //OfType<T>() contournele problème car il n'inclus pas les types incompatibles 👍
            IEnumerable<Contact> contacts = arraylist_contacts.OfType<Contact>();

            foreach (Contact c in contacts)
            {
                Console.WriteLine($"{c.LastName} {c.FirstName} {c.Email} {c.BirthDateYear}");
            }

            /** DEMO Where
            IEnumerable<Contact> jeunes = contacts.Where(c => c.BirthDateYear >= 1990 && c.FirstName[0] == 'D');

            //IEnumerable<Contact> jeunes = from Contact c in contacts
            //                              where c.BirthDateYear >= 1990 && c.FirstName[0] == 'D'
            //                              select c;


            Console.WriteLine("Les jeunes sont :");
            foreach (Contact c in jeunes)
            {
                Console.WriteLine($"\t- {c.BirthDateYear} {c.FirstName}");
            }
            */

            /** DEMO Select

            //IEnumerable<string> emails = contacts.Select( c => c.Email );

            IEnumerable<string> emails = from c in contacts
                                         select c.Email;

            //var persons = contacts.Select( c => new { c.FirstName, c.LastName } );
            var persons = from c in contacts
                          select new { c.FirstName, c.LastName };


            foreach (string email in emails)
            {
                Console.WriteLine($"Email : {email}");
            }

            foreach (var person in persons)
            {
                Console.WriteLine($"Personne : {person.LastName} {person.FirstName}");
            }

            IEnumerable<int> ages = contacts.Select(c => DateTime.Now.Year - c.BirthDateYear);

            foreach (int age in ages)
            {
                Console.WriteLine($"Âge : {age}");
            }
            
            */

            /** DEMO Aggregate func
             

            int nbContact = contacts.Count();

            int nbContactMin4Char = contacts.Count(c => c.LastName.Length >= 4);

            int minCharInName = contacts.Min(c => c.LastName.Length);

            int maxCharInName = contacts.Max(c => c.LastName.Length);

            double averageAge = DateTime.Now.Year - contacts.Average(c => c.BirthDateYear);
             */

            /** DEMO Group By

            //IEnumerable<IGrouping<int, Contact>> group_par_date = contacts.GroupBy(c => c.BirthDateYear);
            IEnumerable<IGrouping<int, Contact>> group_par_date = from c in contacts
                                                                  group c by c.BirthDateYear;

            foreach (IGrouping<int,Contact> group in group_par_date)
            {
                Console.WriteLine($"{group.Key} : {group.Count()}");
                foreach (Contact contact in group)
                {
                    Console.WriteLine($"\t{contact.FirstName} {contact.LastName} {contact.Email}");
                }
            }
             */
        }
    }
}