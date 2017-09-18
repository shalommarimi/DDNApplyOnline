using DAL.Entities;
using System;
using System.Configuration;
using System.IO;
using System.Net.Mail;

namespace BL.Services
{
    public class Notification : INotification
    {

        private string CreatedBody(SubscriberInformation email)
        {
            string path = System.Web.HttpContext.Current.Server.MapPath("~/EmailTemplate.html");
            string Body = string.Empty;
            using (var reader = new StreamReader(path))
            {
                Body = reader.ReadToEnd();
            }

            Body = Body.Replace("{FirstName}", email.FirstName);
            Body = Body.Replace("{LastName}", email.FirstName);
            Body = Body.Replace("{Date}", DateTime.Now.ToShortDateString());

            return Body;
        }




        public void SendEmail(SubscriberInformation email)
        {
            using (var mail = new MailMessage())
            {

                mail.To.Add(email.EmailAddress);
                mail.From = new MailAddress(ConfigurationManager.AppSettings["Sender"].ToString());
                mail.Body = CreatedBody(email);
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
