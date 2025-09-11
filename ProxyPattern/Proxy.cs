using System;

namespace ProxyPattern
{
    // Subject
    public interface IDocument
    {
        void Display();
    }

    // Real Subject
    public class ConfidentialDocument(string content) : IDocument
    {

        public void Display()
        {
            Console.WriteLine($"Confidential Content: {content}");
        }
    }

    // Proxy with access control
    public class DocumentProxy(string content, string currentUserRole) : IDocument
    {
        private readonly ConfidentialDocument _realDocument = new(content);
        private readonly string _currentUserRole = currentUserRole ?? "guest";

        public void Display()
        {
            if (_currentUserRole != "admin")
            {
                Console.WriteLine("Access denied: you do not have permission to view this document.");
                return;
            }

            _realDocument.Display();
        }
    }

}
