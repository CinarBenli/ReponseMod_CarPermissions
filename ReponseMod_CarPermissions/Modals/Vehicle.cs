using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ReponseMod_CarPermissions.Modals
{
    public class Vehicle
    {
        [XmlAttribute]
        public ushort Id { get; set; }

        public Vehicle()
        {
        }

        public Vehicle(ushort id)
        {
            Id = id;
        }
    }
}
