using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fabric_metod.Subscriptions;
using Fabric_metod.Creators;

namespace Fabric_metod.Subscriptions
{
    public class DomesticSubscription : SubscriptionBase
    {
        public DomesticSubscription()
        {
            MonthlyFee = 100;
            MinPeriodMonths = 3;
            Channels.AddRange(new[] { "Новини", "Спорт", "Фільми" });
            Features.Add("Стандартна якість");
        }
    }
}
