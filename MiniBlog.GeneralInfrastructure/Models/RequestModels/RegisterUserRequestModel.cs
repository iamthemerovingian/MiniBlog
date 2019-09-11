using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBlog.GeneralInfrastructure.Models.RequestModels
{
    public class RegisterUserRequestModel
    {
        public string UserPassword { get; set; }
        public string UserName { get; set; }
    }
}
