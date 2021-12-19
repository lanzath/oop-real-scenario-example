namespace Lanza.NotificationContext
{
    // Esta classe não poderá ser extendida pois é dealed.
    public sealed class Notification
    {
        public Notification()
        {

        }

        public Notification(string property, string message)
        {
            this.Property = property;
            this.Message = message;

        }
        public string Property { get; set; }
        public string Message { get; set; }
    }
}
