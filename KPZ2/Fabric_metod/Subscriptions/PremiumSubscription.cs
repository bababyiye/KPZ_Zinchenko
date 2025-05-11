using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fabric_metod.Subscriptions;
using Fabric_metod.Creators;

namespace Fabric_metod.Subscriptions
{
    public class PremiumSubscription : SubscriptionBase
    {
        public PremiumSubscription()
        {
            MonthlyFee = 200;
            MinPeriodMonths = 1;
            Channels.AddRange(new[] { "4K Кіно", "Спорт+", "Преміум шоу" });
            Features.Add("4K якість");
            Features.Add("Доступ з 5 пристроїв");
        }
    }
}
