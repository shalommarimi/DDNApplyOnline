using DAL.Entities;

namespace BL.Services
{
    public interface INotification
    {
        void SendEmail(SubscriberInformation subscriberEmail);
    }
}
