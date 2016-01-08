using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bamboo.Sharp.Api.Model
{

    public class PlanResultKey
    {
        public string key { get; set; }
        public Key entityKey { get; set; }
        public int resultNumber { get; set; }
    }

    public class Artifact
    {
        public int id { get; set; }
        public string label { get; set; }
        public int size { get; set; }
        public bool isSharedArtifact { get; set; }
        public bool isGloballyStored { get; set; }
        public string linkType { get; set; }
        public PlanResultKey planResultKey { get; set; }
    }

    public class Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public PlanResultKey planResultKey { get; set; }
        public string type { get; set; }
        public string label { get; set; }
        public string location { get; set; }
        public string copyPattern { get; set; }
        public int size { get; set; }
        public Artifact artifact { get; set; }
    }

    public class VariableContext
    {
        public string key { get; set; }
        public string value { get; set; }
        public string variableType { get; set; }
        public bool isPassword { get; set; }
    }

    public class DeploymentVersion
    {
        public int id { get; set; }
        public string name { get; set; }
        public object creationDate { get; set; }
        public List<Item> items { get; set; }
        public List<VariableContext> variableContext { get; set; }
        public Operations operations { get; set; }
        public string planBranchName { get; set; }
        public object ageZeroPoint { get; set; }
    }

    public class Agent
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
    }
    
    public class DeployResult
    {
        public DeploymentVersion deploymentVersion { get; set; }
        public string deploymentVersionName { get; set; }
        public int id { get; set; }
        public string deploymentState { get; set; }
        public string lifeCycleState { get; set; }
        public object startedDate { get; set; }
        public object queuedDate { get; set; }
        public object executedDate { get; set; }
        public object finishedDate { get; set; }
        public string reasonSummary { get; set; }
        public Key key { get; set; }
        public Agent agent { get; set; }
        public Operations operations { get; set; }
    }

    public class DeployResults
    {
        public int size { get; set; }
        public List<DeployResult> results { get; set; }
    }
}

