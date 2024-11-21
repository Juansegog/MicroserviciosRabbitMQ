using MediatR;

namespace MicroRabbit.Domain.Core.Events
{
    public abstract class Message : IRequest<bool>
    {
        public string MessagType { get; protected set; }
        protected Message()
        {
            MessagType = GetType().Name;
        }
    }
}
