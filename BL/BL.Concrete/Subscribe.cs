using BL.Services;
using DAL.DBContext;
using DAL.Entities;

namespace BL.BL.Concrete
{
    public class Subscribe : ISubscribe
    {
        private readonly INotification _Notification;


        public Subscribe(INotification iNotification)
        {
            _Notification = iNotification;

        }

        public void RegisterSubscriber(Subscriber _Subscriber)
        {
            using (var db = new ApplyDbContext())
            {

                db.Subscribers.Add(_Subscriber);
                db.SaveChanges();
                _Notification.SendEmail(_Subscriber);
            }

        }


    }

}

