using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet3_classes_
{
    class Client // propriétes simplifiées
    {
        public string Nom { get; init; }
        public string Prenom { get; init; }
        public string Email { get; init; }
        public string Tel { get; init; }

        public Client (string nom, string prenom, string email, string tel)
        {
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Tel = tel;
        }

        public override string ToString() => "Nom: " + Nom + " - Prénom: " + Prenom + " - Email: " + Email + " - Tel: " + Tel;

    }
}
