using AfroFamApi.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using Users.Models;

namespace UsersApi.Services
{
    public class UsersService
    {
        
        private readonly IMongoCollection<UsersModel> _users;

        public UsersService(IAfroFamDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _users = database.GetCollection<UsersModel>(settings.UsersCollectionName);
        }

        public List<UsersModel> Get() =>
            _users.Find(user => true).ToList();

        public UsersModel Get(string id) =>
            _users.Find<UsersModel>(user => user.Id == id).FirstOrDefault();

        public UsersModel Create(UsersModel user)
        {
            _users.InsertOne(user);
            return user;
        }

        public void Update(string id, UsersModel userIn) =>
            _users.ReplaceOne(user => user.Id == id, userIn);

        public void Remove(UsersModel userIn) =>
            _users.DeleteOne(user => user.Id == userIn.Id);

        public void Remove(string id) =>
            _users.DeleteOne(user => user.Id == id);
    }
}