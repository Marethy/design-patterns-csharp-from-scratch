using Adapter;

var smsService = new SmsAdapter(new SmsService());
smsService.SendMessage("Hello via SMS!");
var emailAdapter = new EmailAdapter(new EmailService());
emailAdapter.SendMessage("Hello via Email!");

