using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consol_LocalDB_nosql.Logic;
using Consol_LocalDB_nosql.Model;

namespace Consol_LocalDB_nosql
{
    class Program
    {
        static void Main(string[] args)
        {
            var db=new LocalDB();

            Roles rola = new Roles
            {
                Name = "Super Admin"
            };

            db.InsertOrUpdateRole(rola);
            rola = new Roles
            {
                Name = "Admin"
            };
  
            db.InsertOrUpdateRole(rola);

            var allRoles = db.GetAllRoles();
            List<string>roleId=new List<string>();
            foreach (var _rola in allRoles)
            {
                Console.WriteLine($"Mamy następujące role w bazie: {_rola.Name}");
                roleId.Add(_rola.RoleId.ToString());
            }
            //Twożymy obiekt użytkownika składający się z Osoby, Listy id ról oraz danych użytkownika
            var user = new User
            {
                Nick = "Rambo",
                Password = "P@ssw0rd",
                PersonalData = new Person
                {
                    Email = "rambo@poczta.pl",
                    FirstName = "Johan",
                    LastName = "Balboa"
                },

                UseRolesesId = roleId
            };

            db.InsertOrUpdateFullUser(user);

            var allUser = db.GetAllUser();
            foreach (var _user in allUser)
            {
                Console.WriteLine($"Imię: {_user.PersonalData.FirstName}, Nazwisko: {_user.PersonalData.LastName}, Nick: {_user.Nick}");
            }
            
        }
    }
}
