#region

using System;
using DDDCore.Event;
using Zenject;

#endregion

namespace DDDCore.Implement
{
    public abstract class EventHandler
    {
    #region Private Variables

        private readonly IDomainEventBus domainEventBus;

    #endregion

    #region Constructor

        [Inject]
        protected EventHandler(IDomainEventBus domainEventBus)
        {
            this.domainEventBus = domainEventBus;
        }

    #endregion

    #region Protected Methods

        protected void Register<T>(Action<T> callBackAction) where T : IDomainEvent
        {
            domainEventBus.Register(callBackAction);
        }

    #endregion
    }
}