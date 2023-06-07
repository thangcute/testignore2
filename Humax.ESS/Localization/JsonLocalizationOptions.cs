using Microsoft.Extensions.Localization;

namespace Humax.ESS.Localization
{
    public class JsonLocalizationOptions : LocalizationOptions
    {
        public ResourcesType ResourcesType { get; set; } = ResourcesType.TypeBased;
    }
}