namespace MicroRabbit.Domain.Core.Bus
{
    public interface IEventHandler<in TEvent> : IEventHandler
    {
    }
    public interface IEventHandler { }
}
