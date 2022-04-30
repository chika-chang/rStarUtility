#region

using System;

#endregion

namespace rStarUtility.DDD.DDDTestFrameWork
{
    public class SimpleTest
    {
    #region Protected Variables

        protected readonly int    number = 999;
        protected readonly string id     = "id";

    #endregion

    #region Protected Methods

        protected string GetGuid()
        {
            return Guid.NewGuid().ToString();
        }

    #endregion
    }
}