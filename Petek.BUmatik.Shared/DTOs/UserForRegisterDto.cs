using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Shared.DTOs
{
    public class UserForRegisterDto 
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string LastName { get; set; }
    }
}
