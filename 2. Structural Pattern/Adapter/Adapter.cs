using System;

namespace Adapter;

// The 'Target' interface
// Defines the method the client expects to use
public interface IMessageSender
{
    void SendMessage(string message);
}

// The 'Adaptee' classes
// These have existing functionality but incompatible interfaces
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

// The 'Adapter' classes
// These make the Adaptee compatible with the Target interface
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
