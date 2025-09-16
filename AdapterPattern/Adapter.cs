using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{   
    public interface IMessageSender
    {
        void SendMessage(string message);
    }

    // Adaptee
    public class EmailService
    {
        public void SendEmail(string emailContent)
        {
            Console.WriteLine($"Email sent with content: {emailContent}");
        }
    }
    public class SmsService
    {
        public void SendSms(string smsContent)
        {
            Console.WriteLine($"SMS sent with content: {smsContent}");
        }
    }

    // Adapter

    public class EmailAdapter(EmailService emailService) : IMessageSender
    {
        public void SendMessage(string message)
        {
            emailService.SendEmail(message);
        }
    }
    public class SmsAdapter(SmsService smsService) : IMessageSender
    {
        public void SendMessage(string message)
        {
            smsService.SendSms(message);
        }
    }
}
