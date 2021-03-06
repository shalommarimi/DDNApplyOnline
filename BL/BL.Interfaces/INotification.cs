﻿using DAL.Entities;

namespace BL.Services
{
    public interface INotification
    {
        void SendEmail(Subscriber subscriberEmail);
        string CreateBodyContent(Subscriber subscriber);
    }
}
