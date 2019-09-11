using Effortless.Net.Encryption;
using MiniBlog.DataAccess.Repositories;
using MiniBlog.GeneralInfrastructure.Extenstions;
using MiniBlog.GeneralInfrastructure.Models.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBlog.Business.Services
{
    public class UserManagementService : IUserManagementService
    {
        private readonly IUserRepository _userRepository;

        public UserManagementService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public string RegisterUser(RegisterUserRequestModel requestModel)
        {
            var salt = Strings.CreateSaltFull(128);

            var saltedPassword = requestModel.UserPassword + salt;

            string userPasswordHash = Hash.Create(HashType.SHA512, saltedPassword, string.Empty, false);

            string identifier = Hash.Create(HashType.SHA512, Strings.CreateSaltFull(128), string.Empty, false).Base64Encode();

            bool isSaved = _userRepository.SaveUserPasswordHashAndSalt(requestModel.UserName, userPasswordHash, salt, identifier);

            return identifier;
        }
    }
}
