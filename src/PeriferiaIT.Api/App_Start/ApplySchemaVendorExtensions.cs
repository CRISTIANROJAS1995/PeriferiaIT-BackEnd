using System;
using System.Linq;
using Swashbuckle.Swagger;

namespace PeriferiaIT.Api
{
    internal class ApplySchemaVendorExtensions : ISchemaFilter
    {
        public void Apply(Schema schema, SchemaRegistry schemaRegistry, Type type)
        {
            foreach (var prop in type
                .GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance)
                .Where(p => p.GetCustomAttributes(typeof(Newtonsoft.Json.JsonIgnoreAttribute), true).Any()))
                if (schema?.properties?.ContainsKey(prop.Name) == true)
                    schema.properties?.Remove(prop.Name);
        }
    }
}