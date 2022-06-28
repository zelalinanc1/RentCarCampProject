using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.JWT
{
    //token optionları apideki appsettingste tutarız
    public class TokenOptions
    {
        //tokenımızın kulanıcı kitlesi
        public string Audience { get; set; }
        //imzalayan
        public string Issuer { get; set; }
        public int AccessTokenExpiration { get; set; }
        public string SecurityKey { get; set; }
    }
}
