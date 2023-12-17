using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Telegram.Bot.Extensions;

internal static class StreamExtensions
{
    /// <summary>
    /// Deserialized JSON in Stream into <typeparamref name="T"/>
    /// </summary>
    /// <param name="stream"><see cref="Stream"/> with content</param>
    /// <typeparam name="T">Type of the resulting object</typeparam>
    /// <returns>Deserialized instance of <typeparamref name="T" /> or <c>null</c></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static async Task<T?> DeserializeJsonFromStreamAsync<T>(this Stream? stream)
        where T : class
    {
        if (stream is null || !stream.CanRead) { return default; }

        var searchResult = await JsonSerializer.DeserializeAsync<T>(stream)
            .ConfigureAwait(false);

        return searchResult;
    }
}
