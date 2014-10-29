namespace Bamboo.Sharp.Api.Model
{
    public class Project : BaseNode
    {
        public string Key { get; set; }

        public string Name { get; set; }

        public Link Link { get; set; }

        public Plans Plans { get; set; }
    }
}
