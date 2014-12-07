using System.Xml.Serialization;

namespace Core.Model
{
    public class AttributeType
    {
        public const int StrengthAttribute = 1;
        public const int IntellectAttribute = 2;
        public const int AgilityAttibute = 3;
        public const int MaximumHP = 4;
        public const int PhysicalAttack = 5;
        public const int MagicPower = 6;
        public const int Armor = 7;

        [XmlAttribute(AttributeName = "id")]
        public int Id { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
    }
}
