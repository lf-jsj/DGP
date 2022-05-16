﻿using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace Snap.Data.Visualizer.Core;
internal static class JsonContext
{
    private static JsonSerializerOptions options = CreateDefaultOption();

    public static JsonSerializerOptions CreateDefaultOption()
    {
        return new()
        {
            PropertyNameCaseInsensitive = true,
            WriteIndented = true,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        };
    }

    public static JsonSerializerOptions Options { get => options; set => options = value; }

    public static T? ToObject<T>(Stream jsonStream)
    {
        return JsonSerializer.Deserialize<T>(jsonStream, options);
    }

    public static string Stringify(object obj)
    {
        return JsonSerializer.Serialize(obj, options);
    }
}
