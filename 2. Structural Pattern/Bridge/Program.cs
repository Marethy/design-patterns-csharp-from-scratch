using Bridge;

// Client code can mix and match abstractions with different implementors
var notiService = new Notification(new SmsSender());
notiService.Notify("This is a regular notification.");

var urgentNotiService = new UrgentNotification(new EmailSender());
urgentNotiService.Notify("This is an urgent notification.");
