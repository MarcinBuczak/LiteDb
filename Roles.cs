using LiteDB;

namespace Consol_LocalDB_nosql.Model
{
    public class Roles
    {
        [BsonId]
        public ObjectId RoleId { get; set; }
        /// <summary>
        /// Nazwa roli
        /// </summary>
        public string Name { get; set; }
    }
}