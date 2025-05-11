using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fabric_metod.Subscriptions;
using Fabric_metod.Creators;

namespace Fabric_metod.Creators
{
    public class WebSite : ISubscriptionCreator
    {
        public ISubscription CreateSubscription(string type)
        {
            Console.WriteLine("Створення через WebSite:");
            return CreateByType(type);
        }

        private ISubscription CreateByType(string type)
        {
            switch (type)
            {
                case "Domestic":
                    return new DomesticSubscription();
                case "Educational":
                    return new EducationalSubscription();
                case "Premium":
                    return new PremiumSubscription();
                default:
                    throw new ArgumentException("Невідомий тип підписки");
            }
        }

    }
}
