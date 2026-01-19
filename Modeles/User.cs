using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebGestion.Modeles
{
    class User
    {
        public string Nom {  get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public int Last_active_societe_id { get; set; }

        public User(string nom,string email, string password, string role) {
            Nom = nom;
            Email = email;
            Password = password;
            Role = role;
        }
    }
}
