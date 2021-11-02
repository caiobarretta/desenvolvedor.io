﻿using NerdStore.Core.Messages;
using NerdStore.Core.Messages.CommonMessages.Notifications;
using System.Threading.Tasks;

namespace NerdStore.Core.Communication.Mediator
{
    public interface IMediatorHandler
    {
        Task PublicarEvento<T>(T evento) where T : Event;
        Task<bool> EnviarCommando<T>(T comando) where T : Command;
        Task PublicarNotificacao<T>(T notification) where T : DomainNotification;
    }
}
