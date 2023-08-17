using BackendAssignment1;
using BackendAssignment1.Namespace;

namespace HeroCreatorTests
{
    public class DamageUnitTests
    {
        [Fact]
        public void CheckDamage_NoWeapon()
        {
            Hero barbarian = new Barbarian("Barb");

            double expectedDamage = 1;
            double actualDamage = barbarian.Damage();

            Assert.Equal(expectedDamage, actualDamage); 
        }
        [Fact]
        public void CheckDamage_OneWeapon()
        {
            Hero barbarian = new Barbarian("Barb");
            Item weapon = new Weapon("Common Hatchet", 1, Slot.Weapon, WeaponType.Hatchets, 2);
            barbarian.Equip(weapon);

            double expectedDamage = 2;
            double actualDamage = barbarian.Damage();

            Assert.Equal(expectedDamage, actualDamage);
        }
        [Fact]
        public void CheckDamage_ReplacedWeapon()
        {
            Hero barbarian = new Barbarian("Barb");
            Item weaponOld = new Weapon("Common Hatchet", 1, Slot.Weapon, WeaponType.Hatchets, 2);
            Item weaponNew = new Weapon("Rare Hatchet", 1, Slot.Weapon, WeaponType.Hatchets, 3);
            barbarian.Equip(weaponOld);
            barbarian.Equip(weaponNew);

            double expectedDamage = 3;
            double actualDamage = barbarian.Damage();

            Assert.Equal(expectedDamage, actualDamage);
        }
        [Fact]
        public void CheckDamage_OneWeaponOneArmor()
        {
            Hero barbarian = new Barbarian("Barb");
            Item weapon = new Weapon("Common Hatchet", 1, Slot.Weapon, WeaponType.Hatchets, 2);
            Item armor = new Armor("Common Plate Mail", 1, Slot.Body, ArmorTypes.Plate, new HeroAttributes { Strength = 1, Dexterity = 0, Intelligence = 0 });
            barbarian.Equip(weapon);
            barbarian.Equip(armor);

            double expectedDamage = 2;
            double actualDamage = barbarian.Damage();

            Assert.Equal(expectedDamage, actualDamage);
        }
    }
}
