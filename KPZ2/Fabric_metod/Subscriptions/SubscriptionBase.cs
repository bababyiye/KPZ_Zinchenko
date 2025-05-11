using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fabric_metod.Subscriptions;
using Fabric_metod.Creators;

namespace Fabric_metod.Subscriptions
{
    public abstract class SubscriptionBase : ISubscription
    {
        public decimal MonthlyFee { get; protected set; }
        public int MinPeriodMonths { get; protected set; }
        public List<string> Channels { get; protected set; } = new List<string>();
        public List<string> Features { get; protected set; } = new List<string>();

        public virtual void ShowDetails()
        {
            Console.WriteLine($"Місячна плата: {MonthlyFee} грн");
            Console.WriteLine($"Мінімальний період: {MinPeriodMonths} місяців");
            Console.WriteLine("Канали: " + string.Join(", ", Channels));
            Console.WriteLine("Можливості: " + string.Join(", ", Features));
            Console.WriteLine();
        }
    }
}
