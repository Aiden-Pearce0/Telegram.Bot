﻿using JetBrains.Annotations;

namespace Telegram.Bot.Types;

/// <summary>
/// This object represent a user's profile pictures.
/// </summary>
[PublicAPI]
public class UserProfilePhotos
{
    /// <summary>
    /// Total number of profile pictures the target user has
    /// </summary>
    public int TotalCount { get; set; }

    /// <summary>
    /// Requested profile pictures (in up to 4 sizes each)
    /// </summary>
    public PhotoSize[][] Photos { get; set; } = default!;
}
