using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fabric_metod.Subscriptions;
using Fabric_metod.Creators;


namespace Fabric_metod
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubscriptionCreator web = new WebSite();
            ISubscription webSub = web.CreateSubscription("Domestic");
            webSub.ShowDetails();

            ISubscriptionCreator app = new MobileApp();
            ISubscription appSub = app.CreateSubscription("Educational");
            appSub.ShowDetails();

            ISubscriptionCreator call = new ManagerCall();
            ISubscription callSub = call.CreateSubscription("Premium");
            callSub.ShowDetails();
        }
    }

}
