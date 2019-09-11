using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace MiniBlog.Filters
{
    public class MiniBlogAuthorize : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (SkipAuthorization(actionContext)) return;

            //Get UserId from Header
            var headers = actionContext.Request.Headers;

            // The old Authorization method: token in header.
            if (headers != null && (headers.Contains("token") || headers.Contains("Authorization")))
            {
                string token = string.Empty;

                if (headers.Contains("token"))
                {
                    token = headers.GetValues("token").FirstOrDefault();
                    if (!string.IsNullOrEmpty(token))
                    {
                        string guid = new EncryptionHelper().DecodeToken(token);
                        if (IsValidGuid(actionContext, guid))
                        {
                            return;
                        }
                    }
                }

        }
    }
}