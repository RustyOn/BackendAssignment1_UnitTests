using BackendAssignment1;
using BackendAssignment1.Namespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroCreatorTests
{
    public class TotalAttributeUnitTests
    {
        [Fact]
        public void CheckTotalAttributes_NoEquipment()
        {
            Hero wizard = new Wizard("Leo");

            HeroAttributes expectedTotalAttributes = new HeroAttributes { Strength = 1, Dexterity = 1, Intelligence = 8};
            HeroAttributes actualTotalAttributes = wizard.TotalAttributes();

            Assert.Equivalent(expectedTotalAttributes, actualTotalAttributes);
        }
        [Fact]
        public void CheckTotalAttributes_OneEquipment()
        {
            Hero wizard = new Wizard("Leo");
            Item armor = new Armor("Common Robe", 1, Slot.Body, ArmorTypes.Cloth,
               new HeroAttributes { Strength = 0, Dexterity = 0, Intelligence = 1 });
            wizard.Equip(armor);

            HeroAttributes expectedTotalAttributes = new HeroAttributes { Strength = 1, Dexterity = 1, Intelligence = 9 };
            HeroAttributes actualTotalAttributes = wizard.TotalAttributes();

            Assert.Equivalent(expectedTotalAttributes, actualTotalAttributes);
        }
        [Fact]
        public void CheckTotalAttributes_TwoEquipment()
        {
            Hero wizard = new Wizard("Leo");
            Item armorBody = new Armor("Common Robe", 1, Slot.Body, ArmorTypes.Cloth,
                 new HeroAttributes { Strength = 0, Dexterity = 0, Intelligence = 1 });
            Item armorHead = new Armor("Common Hat", 1, Slot.Head, ArmorTypes.Cloth,
                 new HeroAttributes { Strength = 0, Dexterity = 0, Intelligence = 2 });
            wizard.Equip(armorBody);
            wizard.Equip(armorHead);

            HeroAttributes expectedTotalAttributes = new HeroAttributes { Strength = 1, Dexterity = 1, Intelligence = 11 };
            HeroAttributes actualTotalAttributes = wizard.TotalAttributes();

            Assert.Equivalent(expectedTotalAttributes, actualTotalAttributes);
        }
        [Fact]
        public void CheckTotalAttributes_ReplacedEquipment()
        {
            Hero wizard = new Wizard("Leo");
            Item armorOld = new Armor("Common Robe", 1, Slot.Body, ArmorTypes.Cloth,
                new HeroAttributes { Strength = 0, Dexterity = 0, Intelligence = 1 });
            Item armorNew = new Armor("Rare Robe", 1, Slot.Body, ArmorTypes.Cloth,
                 new HeroAttributes { Strength = 0, Dexterity = 0, Intelligence = 4 });
            wizard.Equip(armorOld);
            wizard.Equip(armorNew);


            HeroAttributes expectedTotalAttributes = new HeroAttributes { Strength = 1, Dexterity = 1, Intelligence = 12 };
            HeroAttributes actualTotalAttributes = wizard.TotalAttributes();

            Assert.Equivalent(expectedTotalAttributes, actualTotalAttributes);
        }
    }
}
