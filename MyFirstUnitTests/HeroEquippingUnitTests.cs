using BackendAssignment1.Namespace;
using BackendAssignment1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroCreatorTests
{
    public class HeroEquippingUnitTests
    {
        [Theory]
        [InlineData("Leo")]

        public void CanEquip_Weapon(string name)
        {
            Hero wizard = new Wizard(name);
            Item weapon = new Weapon("Common Staff", 1, Slot.Weapon, WeaponType.Staffs, 2);

            wizard.Equip(weapon);

            Item expectedWeapon = weapon;
            Item actualWeapon = wizard.GetEquipment(Slot.Weapon);

            Assert.Equivalent(expectedWeapon, actualWeapon);
        }

        [Theory]
        [InlineData("Leo")]

        public void CannotEquip_Weapon_InvalidLevel(string name)
        {
            Hero wizard = new Wizard(name);
            Item weapon = new Weapon("Common Staff", 4, Slot.Weapon, WeaponType.Staffs, 2);

            Assert.Throws<InvalidLevelException>(() => wizard.Equip(weapon));
        }

        [Theory]
        [InlineData("Leo")]

        public void CannotEquip_Weapon_InvalidType(string name)
        {
            Hero wizard = new Wizard(name);
            Item weapon = new Weapon("Common Hatchet", 1, Slot.Weapon, WeaponType.Hatchets, 2);

            Assert.Throws<InvalidWeaponException>(() => wizard.Equip(weapon));
        }

        [Theory]
        [InlineData("Theo")]

        public void CanEquip_Armor(string name)
        {
            Hero wizard = new Wizard(name);
            Item armor = new Armor("Common Robe", 1, Slot.Body, ArmorTypes.Cloth,
                   new HeroAttributes { Strength = 0, Dexterity = 0, Intelligence = 1 });

            wizard.Equip(armor);

            Item expectedArmor = armor;
            Item actualArmor = wizard.GetEquipment(Slot.Body);

            Assert.Equivalent(expectedArmor, actualArmor);
        }

        [Theory]
        [InlineData("Theo")]

        public void CannotEquip_Armor_InvalidLevel(string name)
        {
            Hero wizard = new Wizard(name);
            Item armor = new Armor("Common Robe", 4, Slot.Body, ArmorTypes.Cloth,
                   new HeroAttributes { Strength = 0, Dexterity = 0, Intelligence = 1 });

            Assert.Throws<InvalidLevelException>(() => wizard.Equip(armor));
        }

        [Theory]
        [InlineData("Theo")]

        public void CannotEquip_Armor_InvalidType(string name)
        {
            Hero wizard = new Wizard(name);
            Item armor = new Armor("Common Plate Mail", 1, Slot.Body, ArmorTypes.Plate,
                   new HeroAttributes { Strength = 0, Dexterity = 0, Intelligence = 1 });

            Assert.Throws<InvalidArmorException>(() => wizard.Equip(armor));
        }
    }
}
