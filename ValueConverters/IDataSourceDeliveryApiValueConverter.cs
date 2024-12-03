namespace SmallUmbraco13Example.ValueConverters
{
    /// <summary>
    /// Defines a value converter for converting a data source value to a delivery API value.
    /// Should be implemented by any of our <see cref="Umbraco.Community.Contentment.DataEditors.IDataSourceValueConverter"/> and will be picked-up automatically.
    /// </summary>
    public interface IDataSourceDeliveryApiValueConverter
    {
        Type? GetDeliveryApiValueType(Dictionary<string, object>? config);

        object? ConvertToDeliveryApiValue(Type type, string value);
    }
}
