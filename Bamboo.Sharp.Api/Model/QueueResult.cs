namespace Bamboo.Sharp.Api.Model
{
    public class QueueResult
    {
        public string PlanKey { get; set; }

        public long BuildNumber { get; set; }

        public string BuildResultKey { get; set; }

        public string TriggerReason { get; set; }

        public Link Link { get; set; }
    }
}