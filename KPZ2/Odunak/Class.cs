
namespace Odunak
{
    using System;
    using System.Collections.Generic;

    public abstract class Authenticator
    {
        private static readonly object _lock = new object();
        private static readonly Dictionary<Type, Authenticator> _instances = new Dictionary<Type, Authenticator>();

        protected Authenticator()
        {
            Console.WriteLine("Authenticator instance created.");
        }

        public static T GetInstance<T>() where T : Authenticator, new()
        {
            lock (_lock)
            {
                if (!_instances.ContainsKey(typeof(T)))
                {
                    _instances[typeof(T)] = new T();
                }
                return (T)_instances[typeof(T)];
            }
        }

        public abstract void Authenticate();
    }


    public class MyAuthenticator : Authenticator
    {
        public override void Authenticate()
        {
            Console.WriteLine("MyAuthenticator authenticating...");
        }
    }

    public class AnotherAuthenticator : Authenticator
    {
        public override void Authenticate()
        {
            Console.WriteLine("AnotherAuthenticator authenticating...");
        }
    }
}
