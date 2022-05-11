using Rocket.API;
using System.Collections.Generic;
using ReponseMod_CarPermissions.Modals;

namespace ReponseMod_CarPermissions
{
    public class Config : IRocketPluginConfiguration
    {
        public string ServerLogo;
        public List<ArabaBlacklist> VehicleBlacklists { get; set; } = new List<ArabaBlacklist>();

        public void LoadDefaults()
        {
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