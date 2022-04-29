#region

using rStartUtility.DDDCore.Usecase;
using rStarUtility.DDDCore.Event;
using rStarUtility.DDDCore.Usecase;

#endregion

namespace rStarUtility.DDDCore.Implement
{
    /// <summary>
    /// </summary>
    /// <typeparam name="I">Input</typeparam>
    /// <typeparam name="O">CQRS Output</typeparam>
    /// <typeparam name="R">Repository</typeparam>
    public abstract class UseCase<I , O , R> where I : Input where O : Output
    {
    #region Protected Variables

        protected readonly IDomainEventBus domainEventBus;

        protected readonly R repository;

    #endregion

    #region Constructor

        protected UseCase(IDomainEventBus domainEventBus , R repository)
        {
            this.domainEventBus = domainEventBus;
            this.repository     = repository;
        }

    #endregion

    #region Public Methods

        public abstract void Execute(I input , O output);

    #endregion
    }
}