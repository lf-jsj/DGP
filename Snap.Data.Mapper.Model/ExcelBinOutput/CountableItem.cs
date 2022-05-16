﻿namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class CountableItem : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }
}
