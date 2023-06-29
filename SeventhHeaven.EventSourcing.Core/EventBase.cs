namespace SeventhHeaven.EventSourcing.Core
{
    public abstract class EventBase : IEvent
    {
        public EventBase() =>
            When = DateTime.Now;

        public DateTime When { get; protected set; }
    }
}
