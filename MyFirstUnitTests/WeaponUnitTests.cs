namespace HeroCreatorTests;
using BackendAssignment1;
using BackendAssignment1.Namespace;

public class WeaponUnitTests
{
    [Fact]
    public void CheckIfCorrect_Name()
    {
        Item weapon = new Weapon("Common Hatchet", 1, Slot.Weapon, WeaponType.Hatchets, 2);

        string expectedName = "Common Hatchet";
        string actualName = weapon.GetName();

         Assert.Equal(expectedName, actualName);
    }

    [Fact]
    public void CheckIfCorrect_Level()
    {
        Item weapon = new Weapon("Common Hatchet", 1, Slot.Weapon, WeaponType.Hatchets, 2);

        int expectedLevel = 1;
        int actualLevel = weapon.GetRequiredLevel();
         Assert.Equal(expectedLevel, actualLevel);
    }
    [Fact]
    public void CheckIfCorrect_Slot()
    {
        Item weapon = new Weapon("Common Hatchet", 1, Slot.Weapon, WeaponType.Hatchets, 2);

        Slot expectedSlot = Slot.Weapon;
        Slot actualSlot = weapon.GetSlot();

        Assert.Equal(expectedSlot, actualSlot);
    }
    [Fact]
    public void CheckIfCorrect_WeaponType()
    {
        Item weapon = new Weapon("Common Hatchet", 1, Slot.Weapon, WeaponType.Hatchets, 2);

        WeaponType expectedWeaponType = WeaponType.Hatchets;
        WeaponType actualWeaponType = weapon.GetWeaponType();

        Assert.Equal(expectedWeaponType, actualWeaponType);
    }
    [Fact]
    public void CheckIfCorrect_Damage()
    {
        Item weapon = new Weapon("Common Hatchet", 1, Slot.Weapon, WeaponType.Hatchets, 2);

        int expectedDamage = 2;

        int actualDamage = weapon.GetDamage();

        Assert.Equal(expectedDamage, actualDamage);
    }
}