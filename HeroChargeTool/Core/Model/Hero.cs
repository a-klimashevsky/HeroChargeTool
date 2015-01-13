using System.Collections.Generic;
using System.Xml.Serialization;

namespace Core.Model
{
    public class Hero
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Line Line { get; set; }

        public Type Type { get; set; }

        public List<Role> Roles { get; set; }

        public int BaseStars;

        [XmlArray(ElementName = "base_attributes")]
        public Attribute[] BaseAttributes { get; set; }

        [XmlAttribute(AttributeName = "bsg")]
        public float BaseStrengthGrowth;

        [XmlAttribute(AttributeName = "big")]
        public float BaseIntelectGrowth;

        [XmlAttribute(AttributeName = "bag")]
        public float BaseAgilityGrowth;

        [XmlAttribute(AttributeName = "dsg")]
        public float DiffStrengthGrowth;

        [XmlAttribute(AttributeName = "dig")]
        public float DiffIntelectGrowth;

        [XmlAttribute(AttributeName = "dag")]
        public float DiffAgilityGrowth;

        [XmlIgnore]
        public int Stars;

        [XmlIgnore]
        public float StrengthGrowth
        {
            get { return BaseStrengthGrowth + Stars*DiffStrengthGrowth; }
        }

        [XmlIgnore]
        public float IntelectGrowth
        {
            get { return BaseIntelectGrowth + Stars*DiffIntelectGrowth; }
        }

        [XmlIgnore]
        public float AgilityGrowth
        {
            get { return BaseAgilityGrowth + Stars*DiffAgilityGrowth; }
        }
    }
}
