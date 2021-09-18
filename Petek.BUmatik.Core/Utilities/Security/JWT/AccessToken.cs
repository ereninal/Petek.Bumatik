using Petek.BUmatik.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Core.Utilities.Security.JWT
{
    public class AccessToken
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }

        public int ParentId { get; set; }
        public string ParentEmail { get; set; }
        public string Fullname { get; set; }
        public string Avatar { get; set; }
    }
}
