using System.ComponentModel;
using Exiled.API.Interfaces;

namespace HealthStatus
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        
        [Description("HP STATUS IN BADGE")]
        public bool BadgeWork { get; set; } = true;

        [Description("Normal hp status (100 - 90 hp)")]

        public string Normal { get; set; } = "Normal HP Status";
        public string NormalColor { get; set; } = "lime";
        
        [Description("light hp status (90 - 50 hp)")]

        public string Light { get; set; } = "Light HP Status";
        public string LightColor { get; set; } = "green";
        
        [Description("badly hp status (50 - 20 hp)")]

        public string Badly { get; set; } = "Badly HP Status";
        public string BadlyColor { get; set; } = "orange";
        
        [Description("super badly hp status  (20 - 1 hp)")]

        public string Dead { get; set; } = "Super Badly HP Status";
        public string DeadColor { get; set; } = "red";

        [Description("HP STATUS IN CUSTOMINFO")]
        
        public bool CustomInfoWork { get; set; } = true;
        
        [Description("Normal hp status (100 - 90 hp)")]
        
        public string Normalinfo { get; set; } = "<color=lime> normal hp status in custom info </color>";
        
        [Description("light hp status (90 - 50 hp)")]
        
        public string Lightinfo { get; set; } = "<color=green> light hp status in custom info </color>";
        
        [Description("badly hp status (50 - 20 hp)")]

        public string Badlyinfo { get; set; } = "<color=#F55F33> badly hp status in custom info </color>";
        
        [Description("super badly hp status  (20 - 1 hp)")]

        public string Deadinfo { get; set; } = "<size=25><color=#F57274> super badly hp status in custom info </color></size>";

    }
}