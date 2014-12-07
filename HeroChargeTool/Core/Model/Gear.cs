using System.Collections.Generic;
using System.Xml.Serialization;

namespace Core.Model
{
    public class Gear
    {
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "minlvl")]
        public int MinLevel { get; set; }

        [XmlArray(ElementName = "attributes")]
        public Attribute[] Attributes { get; set; }

        [XmlAttribute(AttributeName = "color")]
        public GearColor GearColor { get; set; }
    }
}
