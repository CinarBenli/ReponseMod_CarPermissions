using Rocket.API;
using Rocket.Core.Plugins;
using Rocket.Unturned.Player;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReponseMod_CarPermissions
{
    public class Class1 : RocketPlugin<Config>
    {
        public static Class1 Instance { get; private set; }

        protected override void Load()
        {
            Instance = this;
            base.Load();
            VehicleManager.onEnterVehicleRequested += Enter;
        }

        private void Enter(Player player, InteractableVehicle vehicle, ref bool shouldAllow)
        {
            UnturnedPlayer pl = UnturnedPlayer.FromPlayer(player);
            if (pl.IsAdmin)
            {
                return;
            }

            if (CarPermisson(vehicle.id) && !CarAllowPerm(pl, vehicle.id))
            {
                Console.WriteLine("1");
                shouldAllow = false;
                return;
            }

        }
        private bool CarPermisson(ushort id) => Configuration.Instance.VehicleBlacklists.Any(k => k.Arabalar.Any(e => e.Id == id));

        private bool CarAllowPerm(UnturnedPlayer oyuncu, ushort id) => Configuration.Instance.VehicleBlacklists.Any(k => oyuncu.HasPermission($"reponse.vehicleblacklist.{k.ArabaBlacklistName}")
                                                                                                                     && k.Arabalar.Any(e => e.Id == id));




    }
}
