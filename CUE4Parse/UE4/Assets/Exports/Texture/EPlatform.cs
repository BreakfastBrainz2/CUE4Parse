using System.ComponentModel;

namespace CUE4Parse.UE4.Assets.Exports.Texture;

public enum EPlatform
{
    [Description("Desktop / Mobile")]
    DesktopMobile,
    [Description("Playstation 4/5")]
    Playstation,
    [Description("Nintendo Switch")]
    NintendoSwitch,
    [Description("Xbox One / Xbox Series X|S")]
    Xbox
}
