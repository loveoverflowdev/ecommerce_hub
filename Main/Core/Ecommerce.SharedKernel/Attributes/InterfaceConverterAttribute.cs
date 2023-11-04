using System.Text.Json.Serialization;

namespace Ecommerce.SharedKernel.Attributes;

[AttributeUsage(AttributeTargets.Interface)]
public class InterfaceConverterAttribute : JsonConverterAttribute
{
    public InterfaceConverterAttribute(Type converterType)
        : base(converterType)
    {
    }
}