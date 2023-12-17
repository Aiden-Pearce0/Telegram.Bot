using Telegram.Bot.Requests.Abstractions;

// ReSharper disable once CheckNamespace
namespace Telegram.Bot.Requests;

/// <summary>
/// Use this method to delete a chat photo. Photos can't be changed for private chats. The bot
/// must be an administrator in the chat for this to work and must have the appropriate
/// admin rights. Returns <see langword="true"/> on success.
/// </summary>
/// <param name="chatId">Unique identifier for the target chat or username of the target channel
/// (in the format <c>@channelusername</c>)
/// </param>
public class DeleteChatPhotoRequest(ChatId chatId)
    : RequestBase<bool>("deleteChatPhoto"),
      IChatTargetable
{
    /// <inheritdoc />
    public ChatId ChatId { get; } = chatId;
}
