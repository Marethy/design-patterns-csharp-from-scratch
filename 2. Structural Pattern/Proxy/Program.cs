using Proxy;

var doc = new ConfidentialDocument("Top Secret Plans");

IDocument proxyGuest = new DocumentProxy(doc, "guest");
proxyGuest.Display();
// Output: Access denied

IDocument proxyAdmin = new DocumentProxy(doc, "admin");
proxyAdmin.Display();
// Output: Confidential Content: Top Secret Plans
