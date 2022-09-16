﻿using Snap.Data.Mapper.Pipeline.Abstraction;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Snap.Data.Mapper.Pipeline.GachaEvent;
internal class GachaEventPipeline : IPipeline
{
    private static readonly TimeSpan UTC8 = TimeSpan.FromHours(8);

    private readonly List<GachaEvent> gachaEvents = new()
    {
        // 1.0 上半
        new("杯装之诗",GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "温迪" },
            UpBlueList = new() { "芭芭拉", "菲谢尔", "香菱" },
            From = new(2020, 9, 28, 6, 0, 0, UTC8),
            To = new(2020, 10, 18, 17, 59, 59, UTC8),
        },
        new("神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "风鹰剑", "阿莫斯之弓" },
            UpBlueList = new() { "笛剑", "流浪乐章", "钟剑", "绝弦", "西风长枪" },
            From = new(2020, 9, 28, 6, 0, 0, UTC8),
            To = new(2020, 10, 18, 17, 59, 59, UTC8)
        },

        // 1.0 下半
        new("闪焰的驻足", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "可莉" },
            UpBlueList = new() { "行秋", "诺艾尔", "砂糖" },
            From = new(2020, 10, 20, 18, 0, 0, UTC8),
            To = new(2020, 11, 10, 14, 59, 59, UTC8)
        },
        new("神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "四风原典", "狼的末路" },
            UpBlueList = new() { "祭礼剑", "祭礼残章", "祭礼大剑", "祭礼弓", "匣里灭辰" },
            From = new(2020, 10, 20, 18, 0, 0, UTC8),
            To = new(2020, 11, 10, 14, 59, 59, UTC8)
        },

        // 1.1 上半
        new("暂别冬都", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "达达利亚" },
            UpBlueList = new() { "迪奥娜", "北斗", "凝光" },
            From = new(2020, 11, 11, 6, 0, 0, UTC8),
            To = new(2020, 12, 1, 15, 59, 59, UTC8)
        },
        new("神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "尘世之锁", "天空之翼" },
            UpBlueList = new() { "笛剑", "昭心", "雨裁", "弓藏", "西风长枪" },
            From = new(2020, 11, 11, 6, 0, 0, UTC8),
            To = new(2020, 12, 1, 15, 59, 59, UTC8)
        },

        // 1.1 下半
        new("陵薮市朝", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "钟离" },
            UpBlueList = new() { "辛焱", "雷泽", "重云" },
            From = new(2020, 12, 1, 18, 0, 0, UTC8),
            To = new(2020, 12, 22, 14, 59, 59, UTC8)
        },
        new("神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "无工之剑", "贯虹之槊" },
            UpBlueList = new() { "匣里龙吟", "西风秘典", "钟剑", "西风猎弓", "匣里灭辰" },
            From = new(2020, 12, 1, 18, 0, 0, UTC8),
            To = new(2020, 12, 22, 14, 59, 59, UTC8)
        },

        // 1.2 上半
        new("深秘之息", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "阿贝多" },
            UpBlueList = new() { "菲谢尔", "砂糖", "班尼特" },
            From = new(2020, 12, 23, 6, 0, 0, UTC8),
            To = new(2021, 1, 12, 15, 59, 59, UTC8)
        },
        new("神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "斫峰之刃", "天空之卷" },
            UpBlueList = new() { "西风剑", "祭礼残章", "西风大剑", "绝弦", "西风长枪" },
            From = new(2020, 12, 23, 6, 0, 0, UTC8),
            To = new(2021, 1, 12, 15, 59, 59, UTC8)
        },

        // 1.2 下半
        new("浮生孰来", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "甘雨" },
            UpBlueList = new() { "香菱", "行秋", "诺艾尔" },
            From = new(2021, 1, 12, 18, 0, 0, UTC8),
            To = new(2021, 2, 2, 14, 59, 59, UTC8)
        },
        new("神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "天空之傲", "阿莫斯之弓" },
            UpBlueList = new() { "祭礼剑", "昭心", "钟剑", "西风猎弓", "匣里灭辰" },
            From = new(2021, 1, 12, 18, 0, 0, UTC8),
            To = new(2021, 2, 2, 14, 59, 59, UTC8)
        },

        // 1.3 上半
        new("烟火之邀", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "魈" },
            UpBlueList = new() { "迪奥娜", "北斗", "辛焱" },
            From = new(2021, 2, 3, 6, 0, 0, UTC8),
            To = new(2021, 2, 17, 15, 59, 59, UTC8)
        },
        new("神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "磐岩结绿", "和璞鸢" },
            UpBlueList = new() { "笛剑", "昭心", "祭礼大剑", "弓藏", "西风长枪" },
            From = new(2021, 2, 3, 6, 0, 0, UTC8),
            To = new(2021, 2, 23, 15, 59, 59, UTC8)
        },

        // 1.3 中场
        new("鱼龙灯昼", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "刻晴" },
            UpBlueList = new() { "凝光", "班尼特", "芭芭拉" },
            From = new(2021, 2, 17, 18, 0, 0, UTC8),
            To = new(2021, 3, 2, 15, 59, 59, UTC8)
        },

        // 1.3 下半
        new("神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "狼的末路", "护摩之杖" },
            UpBlueList = new() { "匣里龙吟", "流浪乐章", "千岩古剑", "祭礼弓", "千岩长枪" },
            From = new(2021, 2, 23, 18, 0, 0, UTC8),
            To = new(2021, 3, 16, 14, 59, 59, UTC8)
        },
        new("赤团开时", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "胡桃" },
            UpBlueList = new() { "行秋", "香菱", "重云" },
            From = new(2021, 3, 2, 18, 0, 0, UTC8),
            To = new(2021, 3, 16, 14, 59, 59, UTC8)
        },

        // 1.4 上半
        new("杯装之诗", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "温迪" },
            UpBlueList = new() { "砂糖", "雷泽", "诺艾尔" },
            From = new(2021, 3, 17, 6, 0, 0, UTC8),
            To = new(2021, 4, 6, 15, 59, 59, UTC8)
        },
        new("神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "天空之刃", "终末嗟叹之诗" },
            UpBlueList = new() { "暗巷闪光", "暗巷的酒与诗", "西风大剑", "西风猎弓", "匣里灭辰" },
            From = new(2021, 3, 17, 6, 0, 0, UTC8),
            To = new(2021, 4, 6, 15, 59, 59, UTC8)
        },

        // 1.4 下半
        new("暂别冬都", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "达达利亚" },
            UpBlueList = new() { "罗莎莉亚", "芭芭拉", "菲谢尔" },
            From = new(2021, 4, 6, 18, 0, 0, UTC8),
            To = new(2021, 4, 27, 14, 59, 59, UTC8)
        },
        new("神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "四风原典", "天空之翼" },
            UpBlueList = new() { "西风剑", "西风秘典", "祭礼大剑", "暗巷猎手", "西风长枪" },
            From = new(2021, 4, 6, 18, 0, 0, UTC8),
            To = new(2021, 4, 27, 14, 59, 59, UTC8)
        },

        // 1.5 上半
        new("陵薮市朝", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "钟离" },
            UpBlueList = new() { "烟绯", "诺艾尔", "迪奥娜" },
            From = new(2021, 4, 28, 6, 0, 0, UTC8),
            To = new(2021, 5, 18, 17, 59, 59, UTC8)
        },
        new("神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "斫峰之刃", "尘世之锁" },
            UpBlueList = new() { "笛剑", "昭心", "千岩古剑", "祭礼弓", "千岩长枪" },
            From = new(2021, 4, 28, 6, 0, 0, UTC8),
            To = new(2021, 5, 18, 17, 59, 59, UTC8)
        },

        // 1.5 下半
        new("浪涌之瞬", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "优菈" },
            UpBlueList = new() { "辛焱", "行秋", "北斗" },
            From = new(2021, 5, 18, 18, 0, 0, UTC8),
            To = new(2021, 6, 8, 14, 59, 59, UTC8)
        },
        new("神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "风鹰剑", "松籁响起之时" },
            UpBlueList = new() { "祭礼剑", "祭礼残章", "雨裁", "弓藏", "匣里灭辰" },
            From = new(2021, 5, 18, 18, 0, 0, UTC8),
            To = new(2021, 6, 8, 14, 59, 59, UTC8)
        },

        // 1.6 上半
        new("闪焰的驻足", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "可莉" },
            UpBlueList = new() { "芭芭拉", "砂糖", "菲谢尔" },
            From = new(2021, 6, 9, 6, 0, 0, UTC8),
            To = new(2021, 6, 29, 17, 59, 59, UTC8)
        },
        new("神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "四风原典", "天空之傲" },
            UpBlueList = new() { "匣里龙吟", "流浪乐章", "钟剑", "幽夜华尔兹", "西风长枪" },
            From = new(2021, 6, 9, 6, 0, 0, UTC8),
            To = new(2021, 6, 29, 17, 59, 59, UTC8)
        },

        // 1.6 下半
        new("叶落风随", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "枫原万叶" },
            UpBlueList = new() { "罗莎莉亚", "班尼特", "雷泽" },
            From = new(2021, 6, 29, 18, 0, 0, UTC8),
            To = new(2021, 7, 20, 14, 59, 59, UTC8)
        },
        new("神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "苍古自由之誓", "天空之卷" },
            UpBlueList = new() { "暗巷闪光", "暗巷的酒与诗", "西风大剑", "暗巷猎手", "匣里灭辰" },
            From = new(2021, 6, 29, 18, 0, 0, UTC8),
            To = new(2021, 7, 20, 14, 59, 59, UTC8)
        },

        // 2.0 上半
        new("白鹭之庭", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "神里绫华" },
            UpBlueList = new() { "凝光", "重云", "烟绯" },
            From = new(2021, 7, 21, 6, 0, 0, UTC8),
            To = new(2021, 8, 10, 17, 59, 59, UTC8)
        },
        new("神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "雾切之回光", "天空之脊" },
            UpBlueList = new() { "西风剑", "西风秘典", "祭礼大剑", "绝弦", "西风长枪" },
            From = new(2021, 7, 21, 6, 0, 0, UTC8),
            To = new(2021, 8, 10, 17, 59, 59, UTC8)
        },

        // 2.0 下半
        new("焰色天河", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "宵宫" },
            UpBlueList = new() { "早柚", "迪奥娜", "辛焱" },
            From = new(2021, 8, 10, 18, 0, 0, UTC8),
            To = new(2021, 8, 31, 14, 59, 59, UTC8)
        },
        new("神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "天空之刃", "飞雷之弦振" },
            UpBlueList = new() { "祭礼剑", "祭礼残章", "雨裁", "西风猎弓", "匣里灭辰" },
            From = new(2021, 8, 10, 18, 0, 0, UTC8),
            To = new(2021, 8, 31, 14, 59, 59, UTC8)
        },

        // 2.1 上半
        new("影寂天下人", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "雷电将军" },
            UpBlueList = new() { "九条裟罗", "香菱", "砂糖" },
            From = new(2021, 9, 1, 6, 0, 0, UTC8),
            To = new(2021, 9, 21, 17, 59, 59, UTC8)
        },
        new("神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "无工之剑", "薙草之稻光" },
            UpBlueList = new() { "匣里龙吟", "流浪乐章", "钟剑", "祭礼弓", "西风长枪" },
            From = new(2021, 9, 1, 6, 0, 0, UTC8),
            To = new(2021, 9, 21, 17, 59, 59, UTC8)
        },

        // 2.1 下半
        new("浮岳虹珠", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "珊瑚宫心海" },
            UpBlueList = new() { "罗莎莉亚", "北斗", "行秋" },
            From = new(2021, 9, 21, 18, 0, 0, UTC8),
            To = new(2021, 10, 12, 14, 59, 59, UTC8)
        },
        new("神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "磐岩结绿", "不灭月华" },
            UpBlueList = new() { "笛剑", "西风秘典", "西风大剑", "绝弦", "匣里灭辰" },
            From = new(2021, 9, 21, 18, 0, 0, UTC8),
            To = new(2021, 10, 12, 14, 59, 59, UTC8)
        },

        // 2.2 上半
        new("暂别冬都", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "达达利亚" },
            UpBlueList = new() { "凝光", "重云", "烟绯" },
            From = new(2021, 10, 13, 6, 0, 0, UTC8),
            To = new(2021, 11, 2, 17, 59, 59, UTC8)
        },
        new("神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "尘世之锁", "冬极白星" },
            UpBlueList = new() { "西风剑", "昭心", "恶王丸", "弓藏", "西风长枪" },
            From = new(2021, 10, 13, 6, 0, 0, UTC8),
            To = new(2021, 11, 2, 17, 59, 59, UTC8)
        },

        // 2.2 下半
        new("赤团开时", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "胡桃" },
            UpBlueList = new() { "托马", "迪奥娜", "早柚" },
            From = new(2021, 11, 2, 18, 0, 0, UTC8),
            To = new(2021, 11, 23, 14, 59, 59, UTC8)
        },
        new("神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "终末嗟叹之诗", "护摩之杖" },
            UpBlueList = new() { "祭礼剑", "流浪乐章", "雨裁", "曚云之月", "断浪长鳍" },
            From = new(2021, 11, 2, 18, 0, 0, UTC8),
            To = new(2021, 11, 23, 14, 59, 59, UTC8)
        },

        // 2.3 上半
        new("深秘之息", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "阿贝多" },
            UpBlueList = new() { "班尼特", "诺艾尔", "罗莎莉亚" },
            From = new(2021, 11, 24, 6, 0, 0, UTC8),
            To = new(2021, 12, 14, 17, 59, 59, UTC8)
        },
        new("浪涌之瞬", GachaType.AvatarEventWish2)
        {
            UpOrangeList = new() { "优菈" },
            UpBlueList = new() { "班尼特", "诺艾尔", "罗莎莉亚" },
            From = new(2021, 11, 24, 6, 0, 0, UTC8),
            To = new(2021, 12, 14, 17, 59, 59, UTC8)
        },
        new("神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "苍古自由之誓", "松籁响起之时" },
            UpBlueList = new() { "匣里龙吟", "暗巷的酒与诗", "祭礼大剑", "暗巷猎手", "匣里灭辰" },
            From = new(2021, 11, 24, 6, 0, 0, UTC8),
            To = new(2021, 12, 14, 17, 59, 59, UTC8)
        },

        // 2.3 下半
        new("鬼门斗宴", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "荒泷一斗" },
            UpBlueList = new() { "五郎", "芭芭拉", "香菱" },
            From = new(2021, 12, 14, 18, 0, 0, UTC8),
            To = new(2022, 1, 4, 14, 59, 59, UTC8)
        },
        new("神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "赤角石溃杵", "天空之翼" },
            UpBlueList = new() { "暗巷闪光", "祭礼残章", "钟剑", "幽夜华尔兹", "西风长枪" },
            From = new(2021, 12, 14, 18, 0, 0, UTC8),
            To = new(2022, 1, 4, 14, 59, 59, UTC8),
        },

        // 2.4 上半
        new("出尘入世", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "申鹤" },
            UpBlueList = new() { "云堇", "凝光", "重云" },
            From = new(2022, 1, 5, 6, 0, 0, UTC8),
            To = new(2022, 1, 25, 17, 59, 59, UTC8)
        },
        new("烟火之邀", GachaType.AvatarEventWish2)
        {
            UpOrangeList = new() { "魈" },
            UpBlueList = new() { "云堇", "凝光", "重云" },
            From = new(2022, 1, 5, 6, 0, 0, UTC8),
            To = new(2022, 1, 25, 17, 59, 59, UTC8)
        },
        new("神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "息灾", "和璞鸢" },
            UpBlueList = new() { "笛剑", "流浪乐章", "西风大剑", "西风猎弓", "千岩长枪" },
            From = new(2022, 1, 5, 6, 0, 0, UTC8),
            To = new(2022, 1, 25, 17, 59, 59, UTC8)
        },

        // 2.4 下半
        new("陵薮市朝", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "钟离" },
            UpBlueList = new() { "行秋", "北斗", "烟绯" },
            From = new(2022, 1, 25, 18, 0, 0, UTC8),
            To = new(2022, 2, 15, 14, 59, 59, UTC8)
        },
        new("浮生孰来", GachaType.AvatarEventWish2)
        {
            UpOrangeList = new() { "甘雨" },
            UpBlueList = new() { "行秋", "北斗", "烟绯" },
            From = new(2022, 1, 25, 18, 0, 0, UTC8),
            To = new(2022, 2, 15, 14, 59, 59, UTC8)
        },
        new("神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "阿莫斯之弓", "贯虹之槊" },
            UpBlueList = new() { "西风剑", "西风秘典", "千岩古剑", "祭礼弓", "匣里灭辰" },
            From = new(2022, 1, 25, 18, 0, 0, UTC8),
            To = new(2022, 2, 15, 14, 59, 59, UTC8)
        },

        // 2.5 上半
        new("华紫樱绯", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "八重神子" },
            UpBlueList = new() { "托马", "菲谢尔", "迪奥娜" },
            From = new(2022, 2, 16, 6, 0, 0, UTC8),
            To = new(2022, 3, 8, 17, 59, 59, UTC8)
        },
        new("神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "磐岩结绿", "神乐之真意" },
            UpBlueList = new() { "祭礼剑", "昭心", "雨裁", "绝弦", "断浪长鳍" },
            From = new(2022, 2, 16, 6, 0, 0, UTC8),
            To = new(2022, 3, 8, 17, 59, 59, UTC8)
        },

        // 2.5 下半
        new("影寂天下人", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "雷电将军" },
            UpBlueList = new() { "班尼特", "辛焱", "九条裟罗" },
            From = new(2022, 3, 8, 18, 0, 0, UTC8),
            To = new(2022, 3, 29, 14, 59, 59, UTC8)
        },
        new("浮岳虹珠", GachaType.AvatarEventWish2)
        {
            UpOrangeList = new() { "珊瑚宫心海" },
            UpBlueList = new() { "班尼特", "辛焱", "九条裟罗" },
            From = new(2022, 3, 8, 18, 0, 0, UTC8),
            To = new(2022, 3, 29, 14, 59, 59, UTC8)
        },
        new("神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "不灭月华", "薙草之稻光" },
            UpBlueList = new() { "匣里龙吟", "恶王丸", "祭礼残章", "曚云之月", "西风长枪" },
            From = new(2022, 3, 8, 18, 0, 0, UTC8),
            To = new(2022, 3, 29, 14, 59, 59, UTC8)
        },

        // 2.6 上半
        new("苍流踏花", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "神里绫人" },
            UpBlueList = new() { "砂糖", "香菱", "云堇" },
            From = new(2022, 3, 30, 6, 0, 0, UTC8),
            To = new(2022, 4, 19, 17, 59, 59, UTC8)
        },
        new("杯装之诗", GachaType.AvatarEventWish2)
        {
            UpOrangeList = new() { "温迪" },
            UpBlueList = new() { "砂糖", "香菱", "云堇" },
            From = new(2022, 3, 30, 6, 0, 0, UTC8),
            To = new(2022, 4, 19, 17, 59, 59, UTC8)
        },
        new("神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "波乱月白经津", "终末嗟叹之诗" },
            UpBlueList = new() { "笛剑", "流浪乐章", "祭礼大剑", "弓藏", "匣里灭辰" },
            From = new(2022, 3, 30, 6, 0, 0, UTC8),
            To = new(2022, 4, 19, 17, 59, 59, UTC8) },

        // 2.6 下半
        new("白鹭之庭", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "神里绫华" },
            UpBlueList = new() { "早柚", "雷泽", "罗莎莉亚" },
            From = new(2022, 4, 19, 18, 0, 0, UTC8),
            To = new(2022, 5, 31, 5, 59, 59, UTC8)
        },
        new("神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "雾切之回光", "无工之剑" },
            UpBlueList = new() { "西风剑", "西风秘典", "钟剑", "西风猎弓", "西风长枪" },
            From = new(2022, 4, 19, 18, 0, 0, UTC8),
            To = new(2022, 5, 31, 5, 59, 59, UTC8)
        },

        // 2.7 上半
        new("素霓伣天", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "夜兰" },
            UpBlueList = new() { "诺艾尔", "芭芭拉", "烟绯" },
            From = new(2022, 5, 31, 6, 0, 0, UTC8),
            To = new(2022, 6, 21, 17, 59, 59, UTC8)
        },
        new("烟火之邀", GachaType.AvatarEventWish2)
        {
            UpOrangeList = new() { "魈" },
            UpBlueList = new() { "诺艾尔", "芭芭拉", "烟绯" },
            From = new(2022, 5, 31, 6, 0, 0, UTC8),
            To = new(2022, 6, 21, 17, 59, 59, UTC8)
        },
        new("神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "若水", "和璞鸢" },
            UpBlueList = new() { "祭礼剑", "昭心", "西风大剑", "祭礼弓", "千岩长枪" },
            From = new(2022, 5, 31, 6, 0, 0, UTC8),
            To = new(2022, 6, 21, 17, 59, 59, UTC8)
        },

        // 2.7 下半
        new("鬼门斗宴", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "荒泷一斗" },
            UpBlueList = new() { "五郎", "久岐忍", "重云" },
            From = new(2022, 6, 21, 18, 0, 0, UTC8),
            To = new(2022, 7, 12, 14, 59, 59, UTC8)
        },
        new("神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "尘世之锁", "赤角石溃杵" },
            UpBlueList = new() { "匣里龙吟", "祭礼残章", "千岩古剑", "绝弦", "匣里灭辰" },
            From = new(2022, 6, 21, 18, 0, 0, UTC8),
            To = new(2022, 7, 12, 14, 59, 59, UTC8)
        },

        // 2.8 上半
        new("叶落风随", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "枫原万叶" },
            UpBlueList = new() { "鹿野院平藏", "托马", "凝光" },
            From = new(2022, 7, 13, 6, 0, 0, UTC8),
            To = new(2022, 8, 2, 17, 59, 59, UTC8)
        },
        new("闪焰的驻足", GachaType.AvatarEventWish2)
        {
            UpOrangeList = new() { "可莉" },
            UpBlueList = new() { "鹿野院平藏", "托马", "凝光" },
            From = new(2022, 7, 13, 6, 0, 0, UTC8),
            To = new(2022, 8, 2, 17, 59, 59, UTC8)
        },
        new("神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "苍古自由之誓", "四风原典" },
            UpBlueList = new() { "暗巷闪光", "流浪乐章", "雨裁", "幽夜华尔兹", "西风长枪" },
            From = new(2022, 7, 13, 6, 0, 0, UTC8),
            To = new(2022, 8, 2, 17, 59, 59, UTC8)
        },

        // 2.8 下半
        new("焰色天河", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "宵宫" },
            UpBlueList = new() { "云堇", "辛焱", "班尼特" },
            From = new(2022, 8, 2, 18, 0, 0, UTC8),
            To = new(2022, 8, 23, 14, 59, 59, UTC8)
        },
        new("神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "斫峰之刃", "飞雷之弦振" },
            UpBlueList = new() { "笛剑", "暗巷的酒与诗", "祭礼大剑", "暗巷猎手", "匣里灭辰" },
            From = new(2022, 8, 2, 18, 0, 0, UTC8),
            To = new(2022, 8, 23, 14, 59, 59, UTC8),
        },

        // 3.0 上半
        new("巡御蘙荟", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "提纳里" },
            UpBlueList = new() { "柯莱", "迪奥娜", "菲谢尔" },
            From = new(2022, 8, 24, 6, 0, 0, UTC8),
            To = new(2022, 9, 9, 17, 59, 59, UTC8)
        },
        new("陵薮市朝", GachaType.AvatarEventWish2)
        {
            UpOrangeList = new() { "钟离" },
            UpBlueList = new() { "柯莱", "迪奥娜", "菲谢尔" },
            From = new(2022, 8, 24, 6, 0, 0, UTC8),
            To = new(2022, 9, 9, 17, 59, 59, UTC8)
        },
        new("神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "猎人之径", "贯虹之槊" },
            UpBlueList = new() { "西风剑", "西风秘典", "钟剑", "绝弦", "西风长枪" },
            From = new(2022, 8, 24, 6, 0, 0, UTC8),
            To = new(2022, 9, 9, 17, 59, 59, UTC8),
        },

        // 3.0 下半
        new("浮生孰来", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "甘雨" },
            UpBlueList = new() { "多莉", "砂糖", "行秋" },
            From = new(2022, 9, 9, 18, 0, 0, UTC8),
            To = new(2022, 9, 27, 14, 59, 59, UTC8)
        },
        new("浮岳虹珠", GachaType.AvatarEventWish2)
        {
            UpOrangeList = new() { "珊瑚宫心海" },
            UpBlueList = new() { "多莉", "砂糖", "行秋" },
            From = new(2022, 9, 9, 18, 0, 0, UTC8),
            To = new(2022, 9, 27, 14, 59, 59, UTC8),
        },
        new("神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "不灭月华", "阿莫斯之弓" },
            UpBlueList = new() { "祭礼剑", "昭心", "西风大剑", "弓藏", "匣里灭辰" },
            From = new(2022, 9, 9, 18, 0, 0, UTC8),
            To = new(2022, 9, 27, 14, 59, 59, UTC8),
        },
    };

    public void Run(string genshinDataFolder, string outputFolder, JsonSerializerOptions options)
    {
        IPipeline.GenerateFile<GachaEvent>(gachaEvents, outputFolder, options);
    }
}