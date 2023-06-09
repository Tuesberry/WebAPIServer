﻿namespace TuesberryAPIServer.ModelDb
{
    public class ItemMasterData
    {
        public Int32 ItemCode { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public Int32 Attribute { get; set; } = 0;
        public Int32 Sell { get; set; } =0;
        public Int32 Buy { get; set; } = 0;
        public Int32 UseLv { get; set; } = 0;
        public Decimal Attack { get; set; } = 0;
        public Decimal Defence { get; set; } = 0;
        public Decimal Magic { get; set; } = 0;
        public Int32 EnchanceMaxCount { get; set; } = 0;
        public bool IsOverlapped { get; set; } = false;
    }

    public class ItemAttributeMasterData
    {
        public Int32 ItemCode { get; set; } = 0;
        public string Name { get; set; } = String.Empty;
    }

    public class AttendanceMasterData
    {
        public Int32 Code { get; set; } = 0;
        public Int32 ItemCode { get; set; } = 0;
        public Int32 Count { get; set; } = 0;
    }

    public class ProductMasterData
    {
        public Int32 Code { get; set; } = 0;
        public Int32 ItemCode { get; set; } = 0;
        public string ItemName { get; set; } = string.Empty;
        public Int32 ItemCount { get; set; } = 0;
    }

    public class StageItemMasterData
    {
        public Int32 Code { get; set; } = 0;
        public Int32 ItemCode { get; set; } = 0;
    }

    public class NpcMasterDataDb
    {
        public Int32 Code { get; set; } = 0;
        public Int32 NpcCode { get; set; } = 0;
        public Int32 Count { get; set; } = 0;
        public Int32 Exp { get; set; } = 0;
    }

    public class NpcMasterData
    {
        public Int32 NpcCode { get; set; } = 0;
        public Int32 Count { get; set; } = 0;
        public Int32 Exp { get; set; } = 0;
    }

    public class LevelUpExpData
    {
        public Int32 Level { get; set; } = 0;
        public Int32 Exp { get; set; } = 0;
    }

    public class DefaultItemData
    {
        public Int32 ItemCode { get; set; } = 0;
        public Int32 Amount { get; set; } = 0;
    }
}
