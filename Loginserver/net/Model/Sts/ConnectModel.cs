using System.Xml.Serialization;

namespace Loginserver.net.Model.Sts
{
    [XmlRoot("Connect")]
    public class ConnectModel
    {
        [XmlElement("ConnType")]
        public int connType { get; set; }

        [XmlElement("Address")]
        public string address { get; set; }

        [XmlElement("ProductType")]
        public int productType { get; set; }

        [XmlElement("AppIndex")]
        public int appIndex { get; set; }

        [XmlElement("Epoch")]
        public long epoch { get; set; }

        [XmlElement("Program")]
        public int program { get; set; }

        [XmlElement("Build")]
        public int build { get; set; }

        [XmlElement("Process")]
        public int process { get; set; }
    }
}
