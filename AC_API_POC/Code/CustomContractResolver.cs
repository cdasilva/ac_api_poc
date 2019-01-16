using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace AssessmentCenter.Code
{
    /// <summary>
    /// This class is used to tweak the JSON serializer to better match the original AC_API JSON output. I think
    /// the differences are mostly negligible to consumers of the API though and it might be better to just let
    /// ASP.NET handle things in the default way.
    /// </summary>

    public sealed class CustomContractResolver : DefaultContractResolver
    {
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            JsonProperty property = base.CreateProperty(member, memberSerialization);
            if (property.PropertyType == typeof(string))
                property.ValueProvider = new NullValueProvider(property.ValueProvider, property.NullValueHandling);
            return property;
        }

        private sealed class NullValueProvider : IValueProvider
        {
            private readonly IValueProvider Provider;
            private readonly NullValueHandling? NullHandling;

            public NullValueProvider(IValueProvider provider, NullValueHandling? nullValueHandling)
            {
                Provider = provider ?? throw new ArgumentNullException(nameof(provider));
                NullHandling = nullValueHandling;
            }

            public object GetValue(object target)
            {
                if (NullHandling.HasValue && NullHandling.Value == NullValueHandling.Ignore && Provider.GetValue(target) == null)
                    return null;

                return Provider.GetValue(target) ?? "";
            }

            public void SetValue(object target, object value)
            {
                Provider.SetValue(target, value);
            }
        }
    }
}
