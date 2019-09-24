using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Users.Models
{
    [BsonIgnoreExtraElements]
    public class UsersModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id
        {
            get; set;
        }

        [BsonElement("user_firstname")]
        public string UserFirstName
        {
            get; set;
        }

        [BsonElement("user_lastname")]
        public string UserLastName
        {
            get; set;
        }

        [BsonElement("user_name")]
        public string UserName
        {
            get; set;
        }

        [BsonElement("user_password")]
        public string UserPassword
        {
            get; set;
        }

        [BsonElement("user_email_address")]
        public string UserEmailAdress
        {
            get; set;
        }

        [BsonElement("user_role")]
        public string UserRole
        {
            get; set;
        }

        [BsonElement("is_active")]
        public bool IsActive
        {
            get; set;
        }

        [BsonElement("user_passwordChangedAt")]
        public DateTime UserPasswordChangedAt
        {
            get; set;
        }

        [BsonElement("date_created")]
        public DateTime DateCreated
        {
            get; set;
        }

    }
}