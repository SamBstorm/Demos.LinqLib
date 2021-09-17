using System;

namespace Demos.LinqLib.MethodeExt
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact c = new Contact { Nom = "Legrain", Prenom = "Samuel", Email = "samuel.legrain@bstorm.be" };
            Console.WriteLine(c.CheckEmail());
            //c = ContactExt.SetNewFirstName(ContactExt.SetNewName(c, "Morre"),"Thierry");
            c = c.SetNewName("Morre").SetNewFirstName("Thierry");
            Console.WriteLine(c.Email);
        }
    }

    static class ContactExt{
        public static bool CheckEmail(this Contact contact)
        {
            string fullName = $"{contact.Prenom.ToLower()}.{contact.Nom.ToLower()}@";
            return fullName == contact.Email.Substring(0, fullName.Length);
        }

        public static Contact SetNewName(this Contact contact, string newName)
        {
            string oldFullName = $"{contact.Prenom.ToLower()}.{contact.Nom.ToLower()}@";
            contact.Nom = newName;
            string fullName = $"{contact.Prenom.ToLower()}.{contact.Nom.ToLower()}@";
            contact.Email = $"{fullName}{contact.Email.Substring(oldFullName.Length)}";
            return contact;
        }

        public static Contact SetNewFirstName(this Contact contact, string newFirstName)
        {
            string oldFullName = $"{contact.Prenom.ToLower()}.{contact.Nom.ToLower()}@";
            contact.Prenom = newFirstName;
            string fullName = $"{contact.Prenom.ToLower()}.{contact.Nom.ToLower()}@";
            contact.Email = $"{fullName}{contact.Email.Substring(oldFullName.Length)}";
            return contact;
        }
    }
}
