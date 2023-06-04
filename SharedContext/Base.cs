using OOPProject.NotificationContext;

namespace OOPProject.SharedContext 
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
    }
}