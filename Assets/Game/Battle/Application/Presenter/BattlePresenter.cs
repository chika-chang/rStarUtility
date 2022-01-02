#region

using Game.Actor.Scripts.Adapter.Controller;
using UniRx;
using Zenject;

#endregion

namespace Game.Battle.Application.Presenter
{
    public class BattlePresenter : IInitializable
    {
    #region Private Variables

        [Inject]
        private Reference reference;

        [Inject]
        private ActorController actorController;

    #endregion

    #region Public Methods

        public void Initialize()
        {
            reference.createActorButton.OnClickAsObservable()
                     .Subscribe(_ => { actorController.CreateActor(); }).AddTo(reference);
        }

    #endregion
    }
}