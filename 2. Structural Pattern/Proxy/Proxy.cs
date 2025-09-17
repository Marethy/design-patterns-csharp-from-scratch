namespace Proxy
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
    public class DocumentProxy(IDocument document, string currentUserRole = "guest") : IDocument
    {

        public void Display()
        {
            if (currentUserRole != "admin")
            {
                Console.WriteLine("Access denied: you do not have permission to view this document.");
                return;
            }

            document.Display();
        }
    }

}
