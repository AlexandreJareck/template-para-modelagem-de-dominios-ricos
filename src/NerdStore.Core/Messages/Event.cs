namespace NerdStore.Core.Messages
{
    public abstract class Event : Message
    {
        public DateTime Timestamp { get; set; }

        public Event()
        {
            Timestamp = DateTime.Now;
        }
    }
}
