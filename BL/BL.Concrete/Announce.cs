using DAL.DBContext;
using DAL.Entities;
using System;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace BL.BL.Concrete
{
    public class Announce
    {


        public void SendEmail(NewContent content)
        {

            using (var context = new ApplyDbContext())
            {

                IQueryable<Subscriber> query = from sub in context.Subscribers
                                               select sub;

                foreach (var s in query)
                {
                    using (var mail = new MailMessage())
                    {
                        var stringBuilder = new StringBuilder();
                        mail.To.Add(s.EmailAddress);
                        mail.From = new MailAddress(ConfigurationManager.AppSettings["Sender"].ToString());
                        mail.Subject = content.PostSubject;
                        stringBuilder.Append("Hi " + s.FirstName + " " + s.LastName);
                        stringBuilder.Append(content.PostBody);
                        stringBuilder.Append("Date Posted: " + content.PostEntryDate);
                        mail.Body = stringBuilder.ToString();
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
    }
}
