using System.Xml.Serialization;

namespace Core.Model
{
    public class Attribute
    {
        [XmlAttribute(AttributeName = "typeId")]
        public int TypeId { get; set; }

        [XmlAttribute(AttributeName = "value")]
        public float Value { get; set; }
    }
}
