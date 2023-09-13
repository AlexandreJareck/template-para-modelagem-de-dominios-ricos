namespace NerdStore.Core.Messages
{
    public abstract class Message
    {
        public string Messagetype { get; protected set; }
        public Guid AggregateId { get; set; }

        protected Message()
        {
            Messagetype = GetType().Name;
        }
    }
}