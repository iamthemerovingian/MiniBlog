using MiniBlog.GeneralInfrastructure.Models.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBlog.Business.Services
{
    public interface IUserManagementService
    {
        string RegisterUser(RegisterUserRequestModel requestModel);
    }
}
