namespace Bamboo.Sharp.Api.Model
{
    public class Plan : BaseNode
    {
        public string ProjectKey { get; set; }

        public string ProjectName { get; set; }

        public Project Project { get; set; }

        public string Description { get; set; }

        public string ShortName { get; set; }
        
        public string BuildName { get; set; }
        
        public string ShortKey { get; set; }
        
        public string Type { get; set; }
        
        public string Enabled { get; set; }
        
        public Link Link { get; set; }
        
        public bool IsFavourite { get; set; }
        
        public bool IsActive { get; set; }
        
        public bool IsBuilding { get; set; }
        
        public int AverageBuildTimeInSeconds { get; set; }
        
        public Actions Actions { get; set; }
        
        public Stages Stages { get; set; }
        
        public Branches Branches { get; set; }
        
        public string Key { get; set; }
        
        public string Name { get; set; }
        
        public PlanKey PlanKey { get; set; }
    }
}
