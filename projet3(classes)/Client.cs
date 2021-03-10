using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet3_classes_
{
    class Client // propriétes simplifiées
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public DateTime DateNaissance;
        public string Email { get; set; }
        public string Tel { get; set; }

        public Client(){}

        public Client(string nom = "", string prenom = "", DateTime dateNaissance = new DateTime() , string email = "", string tel = "")
        {
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
            Email = email;
            Tel = tel;
            // possible: (Nom, Prenom, Email, Tel) = (nom, prenom, email, tel);
        }

        private string Age()
        {
            DateTime now = DateTime.Today;
            int age = now.Year - DateNaissance.Year;
            if (now < DateNaissance.AddYears(age)) age--;
            return age.ToString();
        }


        public override string ToString() => "Nom: " + Nom + " - Prénom: " + Prenom + " - Date naissance: " + DateNaissance + " - Age: " + Age() + " - Email: " + Email + " - Tel: " + Tel +"\n";

    }
}
