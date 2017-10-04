using AutoMapper;
using BL.DTO;
using BL.Services;
using DAL.Entities;

namespace BL.BL.Concrete
{
    public class Subscribe : BaseDbContext, ISubscribe
    {
        private readonly INotification _Notification;


        public Subscribe(INotification iNotification)
        {
            _Notification = iNotification;

        }

        public void RegisterSubscriber(SubscriberDTO _SubscriberDTO)
        {

            var config = new MapperConfiguration(cfg => cfg.CreateMap<SubscriberDTO, Subscriber>());
            var mapper = config.CreateMapper();
            var model = mapper.Map<SubscriberDTO, Subscriber>(_SubscriberDTO);

            db.Subscribers.Add(model);
            db.SaveChanges();
            _Notification.SendEmail(model);
        }


    }

}

