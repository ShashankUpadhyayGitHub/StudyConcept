using System.ComponentModel;

namespace BusinessObject
{
    /// <summary>
    /// Enum Days
    /// </summary>
    public enum EnumDays
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    public enum EnumColor
    {
        RED,
        WHITE,
        YELLOW,
        Orange
    }

    /// <summary>
    /// Enum Card Type
    /// </summary>
    public enum EnumCardType
    {
        Rupay,
        Titanium,
        Platinum
    }

    /// <summary>
    /// Enum Card Type
    /// </summary>
    public enum EnumCardInfo
    {
        [Description("Rupay")]
        Rupay = 1,
        [Description("Titanium Edge")]
        Titanium = 2,
        [Description("Platinum Plus")]
        Platinum = 3
    }
}
