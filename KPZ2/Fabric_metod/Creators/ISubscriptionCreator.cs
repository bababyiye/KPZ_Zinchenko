using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fabric_metod.Subscriptions;
using Fabric_metod.Creators;


namespace Fabric_metod.Creators
{
    public interface ISubscriptionCreator
    {
        ISubscription CreateSubscription(string type);
    }

}
