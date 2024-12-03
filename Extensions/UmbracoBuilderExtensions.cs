using Umbraco.Cms.Core.PropertyEditors;

namespace SmallUmbraco13Example.Extensions;

public static class UmbracoBuilderExtensions
{
    public static IUmbracoBuilder ReplaceConverter<TOld, TNew>(this IUmbracoBuilder builder) where TOld : IPropertyValueConverter where TNew : IPropertyValueConverter
    {
        builder.PropertyValueConverters().InsertAfter<TOld, TNew>();
        builder.PropertyValueConverters().Remove<TOld>();

        return builder;
    }
}