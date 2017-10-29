using System.Collections;
using System.Collections.Generic;
using LiteDB;

namespace Consol_LocalDB_nosql.Model
{
    public class User
    {
        [BsonId]
        public ObjectId UserId { get; set; }
        /// <summary>
        /// Nazwa uzytkownika
        /// </summary>
        public string Nick { get; set; }
        /// <summary>
        /// Hasło
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Dane personalne użytkownika
        /// </summary>
        public Person PersonalData { get; set; }
        /// <summary>
        /// Role użytkownika
        /// </summary>
        public IEnumerable<string> UseRolesesId { get; set; }
    }
}