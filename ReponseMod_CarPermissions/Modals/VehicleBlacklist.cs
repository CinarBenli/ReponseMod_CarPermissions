using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ReponseMod_CarPermissions.Modals
{

    public class VehicleBlacklist
    {
        [XmlAttribute]
        public string VehiclePermissionName { get; set; }

        public List<Vehicle> Vehicles { get; set; }

        public VehicleBlacklist()
        {
        }

        public VehicleBlacklist(string vehiclepermissionname, List<Vehicle> vehicles)
        {
            VehiclePermissionName = vehiclepermissionname;

            Vehicles = vehicles;
        }
    }
}
