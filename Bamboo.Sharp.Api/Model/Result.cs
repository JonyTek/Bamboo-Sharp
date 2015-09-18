namespace Bamboo.Sharp.Api.Model
{
    public class Result : BaseNode
    {
        public string expand { get; set; }
        public Link link { get; set; }
        public Plan plan { get; set; }
        public string planName { get; set; }
        public string projectName { get; set; }
        public string buildResultKey { get; set; }
        public string lifeCycleState { get; set; }
        public int id { get; set; }
        public string buildStartedTime { get; set; }
        public string prettyBuildStartedTime { get; set; }
        public string buildCompletedTime { get; set; }
        public string buildCompletedDate { get; set; }
        public string prettyBuildCompletedTime { get; set; }
        public int buildDurationInSeconds { get; set; }
        public int buildDuration { get; set; }
        public string buildDurationDescription { get; set; }
        public string buildRelativeTime { get; set; }
        public string vcsRevisionKey { get; set; }
        public string buildTestSummary { get; set; }
        public int successfulTestCount { get; set; }
        public int failedTestCount { get; set; }
        public int quarantinedTestCount { get; set; }
        public int skippedTestCount { get; set; }
        public bool continuable { get; set; }
        public bool onceOff { get; set; }
        public bool restartable { get; set; }
        public bool notRunYet { get; set; }
        public bool finished { get; set; }
        public bool successful { get; set; }
        public string buildReason { get; set; }
        public string reasonSummary { get; set; }
        public string key { get; set; }
        public string state { get; set; }
        public string buildState { get; set; }
        public int number { get; set; }
        public int buildNumber { get; set; }
    }

}
