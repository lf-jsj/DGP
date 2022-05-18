﻿namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.WinterCamp;

public class WinterCampExploreExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("openDay")]
    public int OpenDay { get; set; }

    [JsonPropertyName("priority")]
    public int Priority { get; set; }

    [JsonPropertyName("groupID")]
    public int GroupID { get; set; }

    [JsonPropertyName("LBMLOHAAKOG")]
    public int LBMLOHAAKOG { get; set; }

    [JsonPropertyName("rewardID")]
    public int RewardID { get; set; }

    [JsonPropertyName("CGCGOEGGAAA")]
    public IList<CGCGOEGGAAA> CGCGOEGGAAA { get; set; } = default!;
}