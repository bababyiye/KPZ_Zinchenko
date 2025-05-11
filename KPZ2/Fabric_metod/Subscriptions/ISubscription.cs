using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fabric_metod.Subscriptions;
using Fabric_metod.Creators;

namespace Fabric_metod.Subscriptions
{
    public interface ISubscription
    {
        decimal MonthlyFee { get; }
        int MinPeriodMonths { get; }
        List<string> Channels { get; }
        List<string> Features { get; }
        void ShowDetails();
    }
}
