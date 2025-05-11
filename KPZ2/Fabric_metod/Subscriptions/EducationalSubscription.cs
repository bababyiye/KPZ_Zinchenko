using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fabric_metod.Subscriptions;
using Fabric_metod.Creators;

namespace Fabric_metod.Subscriptions
{
    public class EducationalSubscription : SubscriptionBase
    {
        public EducationalSubscription()
        {
            MonthlyFee = 80;
            MinPeriodMonths = 6;
            Channels.AddRange(new[] { "Освітні", "Документальні" });
            Features.Add("Доступ до лекцій");
            Features.Add("Без реклами");
        }
    }
}
