#region

using System;

#endregion

namespace rStarUtility.DDD.DDDTestFrameWork
{
    public static class ScenarioExtension
    {
    #region Public Variables

        public static Scenario And(this Scenario scenario , string annotation , Action action)
        {
            action.Invoke();
            return scenario;
        }

        public static Scenario Given(this Scenario scenario , string annotation , Action action)
        {
            action.Invoke();
            return scenario;
        }

        public static Scenario Then(this Scenario scenario , string annotation , Action action)
        {
            action.Invoke();
            return scenario;
        }

        public static Scenario When(this Scenario scenario , string annotation , Action action)
        {
            action.Invoke();
            return scenario;
        }

    #endregion
    }
}