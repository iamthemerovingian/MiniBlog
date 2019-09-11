using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBlog.DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        private string sqlConnectionString = ConfigurationManager.ConnectionStrings["sqlDb"].ToString();
        public bool SaveUserPasswordHashAndSalt(object userName, string userPasswordHash, string salt, string identifier)
        {
            var sql = @"
            --declare @userName varchar(128) = 'testUser'
            --declare @passwordHash varchar(256) = 'testHash'
            --declare @passwordSalt varchar(256) = 'testSalt'
            --declare @identifier varchar(256) = 'testIdentifier'


            insert into users (userName, passwordHash, passwordSalt, identifier)
            values (@userName, @passwordHash, @passwordSalt, @identifier)
            ";

            using (var connection = new SqlConnection(sqlConnectionString))
            {

                var affectedRows = connection.Execute(sql,
                    new
                    {
                        userName = userName,
                        passwordHash =  userPasswordHash,
                        passwordSalt = salt,
                        identifier = identifier}
                    );

                Console.WriteLine(affectedRows);


                return affectedRows > 0;
            }
        }
    }
}
