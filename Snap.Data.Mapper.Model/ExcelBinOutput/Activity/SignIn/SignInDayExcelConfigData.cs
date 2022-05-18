﻿namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.SignIn;

public class SignInDayExcelConfigData : DataObject
{
    [JsonPropertyName("ConfigId")]
    public int ConfigId { get; set; }

    [JsonPropertyName("DayCount")]
    public int DayCount { get; set; }

    [JsonPropertyName("PeriodId")]
    public int PeriodId { get; set; }

    [JsonPropertyName("RewardItemList")]
    public IList<RewardItem> RewardItemList { get; set; } = default!;
}