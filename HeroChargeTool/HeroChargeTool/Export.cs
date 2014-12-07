using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Core.Model;
using Attribute = Core.Model.Attribute;

namespace HeroChargeTool
{
    public class Export
    {
        private static readonly AttributeType Strength = new AttributeType {Id = 1, Name = "Strength"};
        private static readonly AttributeType Intellect = new AttributeType { Id = 2, Name = "Intellect" };
        private static readonly AttributeType Agility = new AttributeType { Id = 3, Name = "Agility" };
        private static readonly AttributeType MaximumHP = new AttributeType { Id = 4, Name = "Maximum HP" };
        private static readonly AttributeType PhysicalAttack = new AttributeType { Id = 5, Name = "Physical Attack" };
        private static readonly AttributeType MagicPower = new AttributeType { Id = 6, Name = "Magic Power" };
        private static readonly AttributeType Armor = new AttributeType { Id = 7, Name = "Armor" };
        private static readonly AttributeType MagicResistance = new AttributeType { Id = 8, Name = "Magic Resistance" };
        private static readonly AttributeType PhysicalCrit = new AttributeType { Id = 9, Name = "Physical Crit" };
        private static readonly AttributeType HpRegen = new AttributeType { Id = 10, Name = "Hp Regen" };
        private static readonly AttributeType EnergyRegen = new AttributeType { Id = 11, Name = "Energy Regen" };
        private static readonly AttributeType Dodge = new AttributeType { Id = 12, Name = "Dodge" };
        private static readonly AttributeType ArmorPenetration = new AttributeType { Id = 13, Name = "Armor Penetration" };
        private static readonly AttributeType IgnoreMagicResistance = new AttributeType { Id = 14, Name = "Ignore Magic Resistance" };
        private static readonly AttributeType ImproveHealing = new AttributeType { Id = 15, Name = "Improve Healing in %" };
        public static AttributeType[] _attributesType = new AttributeType[]
            {
                Strength,
                Intellect,
                Agility,
                MaximumHP,
                PhysicalAttack,
                MagicPower,
                Armor,
                MagicResistance,
                PhysicalCrit,
                HpRegen,
                EnergyRegen,
                Dodge,
                ArmorPenetration,
                IgnoreMagicResistance,
                ImproveHealing, 
            };

        private static readonly Gear WakDolBlade = new Gear
            {
                Name = "Wak-dol Blade",
                MinLevel = 1,
                Attributes = new Attribute[]
                    {
                        new Attribute {TypeId = PhysicalAttack.Id, Value = 6},
                    }
            };

        private static readonly Gear InhoBerry = new Gear
            {
                Name = "Inho Berry",
                MinLevel = 2,
                Attributes = new Attribute[]
                    {
                        new Attribute {TypeId = Strength.Id, Value = 1},
                        new Attribute {TypeId = Intellect.Id, Value = 1},
                        new Attribute {TypeId = Agility.Id, Value = 1},
                    }
            };

        private static readonly Gear EmeraldTorc = new Gear
            {
                Name = "Emerald Torc",
                MinLevel = 2,
                Attributes = new Attribute[]
                    {
                        new Attribute {TypeId = Strength.Id, Value = 2},
                        new Attribute {TypeId = Intellect.Id, Value = 2},
                        new Attribute {TypeId = Agility.Id, Value = 2},
                    }
            };

        public static Gear[] gears = new Gear[]
            {
                WakDolBlade,
                InhoBerry,
                EmeraldTorc
            };
    }
}
