using BL.Services;
using DAL.Entities;
using System;
using System.Configuration;
using System.IO;
using System.Net.Mail;

namespace BL.BL.Concrete
{
    public class Notification : INotification
    {
        public string CreateBodyContent(Subscriber subscriber)
        {
            string path = System.Web.HttpContext.Current.Server.MapPath("~/EmailTemplate.html");
            string Body = string.Empty;
            using (var reader = new StreamReader(path))
            {
                Body = reader.ReadToEnd();
            }

            Body = Body.Replace("{FirstName}", subscriber.FirstName);
            Body = Body.Replace("{LastName}", subscriber.LastName);
            Body = Body.Replace("{Date}", DateTime.Now.ToShortDateString());
            Body = Body.Replace("{content}", "Thank you for Subscribing to Dynamic DNA");
            return Body;
        }



        public void SendEmail(Subscriber email)
        {

            using (var mail = new MailMessage())
            {

                mail.To.Add(email.EmailAddress);
                mail.From = new MailAddress(ConfigurationManager.AppSettings["Sender"].ToString());
                mail.Body = CreateBodyContent(email);
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = ConfigurationManager.AppSettings["Host"].ToString();
                smtp.Port = Convert.ToInt32(ConfigurationManager.AppSettings["Port"]);
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential
                (ConfigurationManager.AppSettings["Sender"].ToString(), ConfigurationManager.AppSettings["Password"].ToString());
                smtp.EnableSsl = true;
                smtp.Send(mail);

            }

        }


    }
}
