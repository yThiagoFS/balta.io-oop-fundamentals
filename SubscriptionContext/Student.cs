using OOPProject.SharedContext;
using OOPProject.NotificationContext;

namespace OOPProject.SubscriptionContext
{
    public class Student : Base 
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }

        public User User { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public IList<Subscription> Subscriptions { get; set; }

        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);

        public void CreateSubscription(Subscription sub)
        {
            if(IsPremium)
            {
                AddNotification(new Notification("Premium", "O aluno já tem uma assinatura ativa."));
                return;
            }
            else 
                Subscriptions.Add(sub);
        }
    }
}