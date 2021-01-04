using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuthenticationApp.Models
{
    public class UserCredentialModel
    {
        public string EmailAddress { get; set; }
        public string Password { get; set; }
    }
    public class UserModel
    {
        public int UserId { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        
    }

    public class TokenModel {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public string expires_in { get; set; }
    }
}
