using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Client_net
{
    class Authentication
    {
        public class Subscriber
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string HomeCountry { get; set; }
            public int Id { get; set; }
            public string Email { get; set; }
            public string Login { get; set; }
        }

        public class Data
        {
            public string subscriptionStatus { get; set; }
            public string subscriptionTokenLegacy { get; set; }
            public string subscriptionToken { get; set; }
        }

        public class RootObject
        {
            public string SessionId { get; set; }
            public bool PasswordIsTemporary { get; set; }
            public Subscriber Subscriber { get; set; }
            public string Country { get; set; }
            public Data data { get; set; }
        }
    }
}
