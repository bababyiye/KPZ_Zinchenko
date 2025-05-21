using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odunak
{
    class Program
    {
        static void Main()
        {
            var auth1 = Authenticator.GetInstance<MyAuthenticator>();
            auth1.Authenticate();

            var auth2 = Authenticator.GetInstance<MyAuthenticator>();
            Console.WriteLine(object.ReferenceEquals(auth1, auth2)); 

            var auth3 = Authenticator.GetInstance<AnotherAuthenticator>();
            auth3.Authenticate();

            Console.WriteLine(object.ReferenceEquals(auth1, auth3)); 

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
