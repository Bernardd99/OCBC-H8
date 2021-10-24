using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.Configuration
{
    public class AuthResult
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public bool Success { get; set; }
        public List<string> Errors { get; set; }
    }

    public class DetailResult
    {
        public List<string> Message { get; set; }
        public object result { get; set; }
        public bool Success { get; set; }
    }
}
