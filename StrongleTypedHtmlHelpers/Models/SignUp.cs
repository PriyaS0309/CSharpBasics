using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StrongleTypedHtmlHelpers.Models
{
    public class SignUp
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public string Email { get; set; }
        public string  Gender { get; set; }
        public string Comment { get; set; }
    }
}