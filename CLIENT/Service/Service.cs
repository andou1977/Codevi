using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Text;

namespace Com.ProjetCodevi.Service
{
    public class Service
    {
        public string EnvoyerEmail(string destinataire, string expediteur, string sujet, string message)
        {
            SmtpClient client = new SmtpClient();
            MailMessage msg = new MailMessage();
            System.Net.NetworkCredential smtpcredits = new System.Net.NetworkCredential("petit.william32@gmail.com", "mercimondieu0000");

            string mess = null;

            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.UseDefaultCredentials = false;
            client.Credentials = smtpcredits;
            client.EnableSsl = true;
            //convertion des emails
            MailAddress from = new MailAddress(expediteur);
            MailAddress to = new MailAddress(destinataire);
            //configuration des messages
            msg.Subject = sujet;
            msg.Body = message;
            msg.From = from;
            msg.To.Add(to);
            try
            {
                client.Send(msg);

                mess="Email envoyé";

            }
            catch (SmtpException ex)
            {
                mess=""+ex.Message;
            }
            return mess;
        }
    }
}
