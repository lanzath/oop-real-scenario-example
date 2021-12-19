using System.Collections.Generic;
using System.Linq;
using Lanza.NotificationContext;
using Lanza.SharedContext;

namespace Lanza.SubscriptionContext
{
    public class Student : Base
    {
        public Student()
        {
            Subscriptons = new List<Subscription>();
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }
        public IList<Subscription> Subscriptons { get; set; }
        public bool IsPremium => Subscriptons.Any(x => !x.IsInvalid);

        public void CreateSubscription(Subscription subscription)
        {
            if (IsPremium)
            {
                AddNotification(new Notification("Premium", "Aluno já possui uma assinatura ativa"));
                return;
            }

            Subscriptons.Add(subscription);
        }
    }
}
