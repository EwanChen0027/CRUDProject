using Microsoft.Extensions.Configuration.Json;

namespace CRUDProject.Utility
{
    public class CustomJsonConfigSource : JsonConfigurationSource
    {
        public override IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            EnsureDefaults(builder);
            return new CustomJsonConfigProvider(this);
        }
    }
}
