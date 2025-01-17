namespace rStarUtility.DDD.Implement.CQRS
{
    public interface Presenter<M> where M : ViewModel
    {
    #region Public Methods

        public M BuildViewModel();

    #endregion
    }
}