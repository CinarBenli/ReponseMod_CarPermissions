using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ReponseMod_CarPermissions.Modals
{
    public class Araba
    {
        [XmlAttribute]
        public ushort Id { get; set; }

        public Araba()
        {
        }

        public Araba(ushort id)
        {
            Id = id;
        }
    }
}
