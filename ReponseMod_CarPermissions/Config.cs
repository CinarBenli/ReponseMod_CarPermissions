using Rocket.API;
using System.Collections.Generic;
using ReponseMod_CarPermissions.Modals;

namespace ReponseMod_CarPermissions
{
    public class Config : IRocketPluginConfiguration
    {
        public string ServerLogo;
        public string WarningMessage;
        public List<VehicleBlacklist> VehicleBlacklists { get; set; } = new List<VehicleBlacklist>();

        public void LoadDefaults()
        {
            ServerLogo = "https://media.discordapp.net/attachments/959142220366237796/962008357990977626/122.png";
            WarningMessage = "You <color=red>Don't Have</color> The Necessary <color=yellow>Authority</color> To Get In The <color=orange>Car</color>.";
            VehicleBlacklists = new List<VehicleBlacklist>
            {
                new VehicleBlacklist
                (
                    "hava",
                    new List<Vehicle>
                    {
                        new Vehicle(1),
                        new Vehicle(2),
                        new Vehicle(3)
                    }
                ),
                new VehicleBlacklist
                (
                    "tank",
                    new List<Vehicle>
                    {
                        new Vehicle(140),
                                                new Vehicle(96)

                    }
                )
            };
        }
    }
}