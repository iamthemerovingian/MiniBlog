using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBlog.DataAccess.Repositories
{
    public interface IUserRepository
    {
        bool SaveUserPasswordHashAndSalt(object userName, string userPasswordHash, string salt, string identifier);
    }
}
