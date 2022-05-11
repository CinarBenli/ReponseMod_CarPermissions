using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ReponseMod_CarPermissions.Modals
{

    public class ArabaBlacklist
    {
        [XmlAttribute]
        public string ArabaBlacklistName { get; set; }

        public List<Araba> Arabalar { get; set; }

        public ArabaBlacklist()
        {
        }

        public ArabaBlacklist(string arabablacklistname, List<Araba> arabalar)
        {
            ArabaBlacklistName = arabablacklistname;

            Arabalar = arabalar;
        }
    }
}
