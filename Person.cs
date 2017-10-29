using LiteDB;

namespace Consol_LocalDB_nosql.Model
{
    public class Person
    {
        [BsonId]
        public ObjectId PersonId { get; set; }
        /// <summary>
        /// Imię
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Nazwisko
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }
    }
}