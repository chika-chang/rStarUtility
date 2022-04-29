#region

using System;
using rStarUtility.DDDCore.Event;
using Zenject;

#endregion

namespace rStarUtility.DDDCore.Implement
{
    public abstract class DomainEventHandler
    {
    #region Private Variables

        private readonly IDomainEventBus domainEventBus;

    #endregion

    #region Constructor

        [Inject]
        protected DomainEventHandler(IDomainEventBus domainEventBus)
        {
            this.domainEventBus = domainEventBus;
        }

    #endregion

    #region Protected Methods

        protected void Register<T>(Action<T> callBackAction) where T : DomainEvent
        {
            domainEventBus.Register(callBackAction);
        }

    #endregion
    }
}