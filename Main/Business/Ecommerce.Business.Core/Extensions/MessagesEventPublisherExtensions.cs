using DotLiquid;
using Ecommerce.Business.Core.Events.Messages;
using Ecommerce.Domain;
using Ecommerce.Domain.Messages;
using MediatR;

namespace Ecommerce.Business.Core.Extensions
{
    public static class MessagesEventPublisherExtensions
    {
        public static async Task EntityTokensAdded<T>(this IMediator mediator, T entity, Drop liquidDrop, LiquidObject liquidObject) where T : ParentEntity
        {
            await mediator.Publish(new EntityTokensAddedEvent<T>(entity, liquidDrop, liquidObject));
        }

        public static async Task MessageTokensAdded(this IMediator mediator, MessageTemplate message, LiquidObject liquidObject)
        {
            await mediator.Publish(new MessageTokensAddedEvent(message, liquidObject));
        }
    }
}
