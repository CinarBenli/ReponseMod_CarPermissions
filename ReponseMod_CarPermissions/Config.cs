using Rocket.API;
using System.Collections.Generic;
using ReponseMod_CarPermissions.Modals;

namespace ReponseMod_CarPermissions
{
    public class Config : IRocketPluginConfiguration
    {
        public string ServerLogo;
        public string WarningMessage;
        public List<ArabaBlacklist> VehicleBlacklists { get; set; } = new List<ArabaBlacklist>();

        public void LoadDefaults()
        {
            ServerLogo = "https://media.discordapp.net/attachments/959142220366237796/962008357990977626/122.png";
            WarningMessage = "You <color=red>Don't Have</color> The Necessary <color=yellow>Authority</color> To Get In The <color=orange>Car</color>.";
            VehicleBlacklists = new List<ArabaBlacklist>
            {
                new ArabaBlacklist
                (
                    "hava",
                    new List<Araba>
                    {
                        new Araba(1),
                        new Araba(2),
                        new Araba(3)
                    }
                ),
                new ArabaBlacklist
                (
                    "tank",
                    new List<Araba>
                    {
                        new Araba(140),
                        new Araba(308),
                        new Araba(309),
                        new Araba(310),
                        new Araba(363),
                        new Araba(116)
                    }
                )
            };
        }
    }
}