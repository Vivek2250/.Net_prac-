namespace day12_delegate_task1
{
    public delegate void StatusUpdateHandler(string statusMessage);

    public class Services
    {
        public static void LoggingService(string statusMessage)
        {
            Console.WriteLine($"Successfully logged in! {statusMessage}");
        }

        public static void NotificationService(string statusMessage)
        {
            Console.WriteLine($"Notification Enabled! {statusMessage}");
        }

        public static void AuditService(string statusMessage)
        {
            Console.WriteLine($"Auditing Done! {statusMessage}");
        }
    }

    public class program
    {
        public static void Main()
        {
            StatusUpdateHandler status;
            status = Services.LoggingService;
            status += Services.NotificationService;
            status += Services.AuditService;
            status("Account Active");

        }
    }
}