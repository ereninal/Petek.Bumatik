using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;


namespace Petek.BUmatik.Core.Utilities.Security.Encryption
{
    public static class SecurityHelper
    {
        public static SecurityKey CreateSecurityKey(string securiyKey)
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securiyKey));
        }
    }
}
