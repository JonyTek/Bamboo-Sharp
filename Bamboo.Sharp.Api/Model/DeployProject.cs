using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bamboo.Sharp.Api.Model
{
    public class Key
    {
        public string key { get; set; }
    }

    public class Operations
    {
        public bool canView { get; set; }
        public bool canEdit { get; set; }
        public bool canDelete { get; set; }
        public bool allowedToExecute { get; set; }
        public bool canExecute { get; set; }
        public bool allowedToCreateVersion { get; set; }
        public bool allowedToSetVersionStatus { get; set; }
    }

    public class Environment
    {
        public int id { get; set; }
        public Key key { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int deploymentProjectId { get; set; }
        public Operations operations { get; set; }
        public int position { get; set; }
        public string configurationState { get; set; }
    }

    public class DeployProject
    {
        public int id { get; set; }
        public Key key { get; set; }
        public string name { get; set; }
        public PlanKey planKey { get; set; }
        public string description { get; set; }
        public List<Environment> environments { get; set; }
        public Operations operations { get; set; }
    }
}
