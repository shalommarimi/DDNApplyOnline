using ApplyOnline.DataContext;
using DAL.Entities;

namespace BL.Services
{
    public class Subscribe : ISubscribe
    {


        public void RegisterSubscriber(SubscriberInformation subscriber)
        {
            try
            {
                var _ApplicantDbContext = new ApplicantsDbContext();
                _ApplicantDbContext.Subscribers.Add(subscriber);
                _ApplicantDbContext.SaveChanges();
            }
            catch (System.Exception)
            {
                throw;

            }

        }

    }
}
