using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace MPACorePHONE.Localization
{
    public static class MPACorePHONELocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(MPACorePHONEConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(MPACorePHONELocalizationConfigurer).GetAssembly(),
                        "MPACorePHONE.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
