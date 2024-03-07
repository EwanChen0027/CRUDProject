using Microsoft.Extensions.Configuration.Json;

namespace CRUDProject.Utility
{
    public class CustomJsonConfigProvider : JsonConfigurationProvider
    {
        public CustomJsonConfigProvider(JsonConfigurationSource source) : base(source)
        {
        }
        public override void Load(Stream stream)
        {
            base.Load(stream);
        }
    }
}
