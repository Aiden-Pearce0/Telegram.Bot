using Telegram.Bot.Types.ReplyMarkups;

// ReSharper disable once CheckNamespace
namespace Telegram.Bot.Requests;

/// <summary>
/// Use this method to edit live location messages. A location can be edited until its
/// <see cref="Types.Location.LivePeriod"/> expires or editing is explicitly disabled by a call to
/// <see cref="StopInlineMessageLiveLocationRequest"/>. On success <see langword="true"/> is returned.
/// </summary>
/// <param name="inlineMessageId">Identifier of the inline message</param>
/// <param name="latitude">Latitude of new location</param>
/// <param name="longitude">Longitude of new location</param>
public class EditInlineMessageLiveLocationRequest(string inlineMessageId, double latitude, double longitude)
    : RequestBase<bool>("editMessageLiveLocation")
{
    /// <inheritdoc cref="Abstractions.Documentation.InlineMessageId"/>
    public string InlineMessageId { get; } = inlineMessageId;

    /// <summary>
    /// Latitude of new location
    /// </summary>
    public double Latitude { get; } = latitude;

    /// <summary>
    /// Longitude of new location
    /// </summary>
    public double Longitude { get; } = longitude;

    /// <summary>
    /// The radius of uncertainty for the location, measured in meters; 0-1500
    /// </summary>
    public float? HorizontalAccuracy { get; set; }

    /// <summary>
    /// Direction in which the user is moving, in degrees. Must be between 1 and 360 if specified.
    /// </summary>
    public int? Heading { get; set; }

    /// <summary>
    /// Maximum distance for proximity alerts about approaching another chat member, in meters. Must be
    /// between 1 and 100000 if specified.
    /// </summary>
    public int? ProximityAlertRadius { get; set; }

    /// <inheritdoc cref="Abstractions.Documentation.ReplyMarkup"/>
    public InlineKeyboardMarkup? ReplyMarkup { get; set; }
}
