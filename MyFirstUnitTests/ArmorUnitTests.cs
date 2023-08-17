
using BackendAssignment1;
using BackendAssignment1.Namespace;

namespace HeroCreatorTests
{
    public class ArmorUnitTests
    {
        [Fact]

        public void CheckIfCorrect_Name()
        {
            Item armor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorTypes.Plate, 
                new HeroAttributes{ Strength = 1, Dexterity = 0, Intelligence = 0});

            string expectedName = "Common Plate Chest";
            string actualName = armor.GetName();

            Assert.Equal(expectedName, actualName);
        }

        [Fact]

        public void CheckIfCorrect_Level()
        {
            Item armor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorTypes.Plate,
                new HeroAttributes { Strength = 1, Dexterity = 0, Intelligence = 0 });

           int expectedLevel = 1;
            int actualLevel = armor.GetRequiredLevel();

            Assert.Equal(expectedLevel, actualLevel);
        }

        [Fact]

        public void CheckIfCorrect_Slot()
        {
            Item armor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorTypes.Plate,
                new HeroAttributes { Strength = 1, Dexterity = 0, Intelligence = 0 });

            Slot expectedSlot = Slot.Body;
            Slot actualSlot = armor.GetSlot();

            Assert.Equal(expectedSlot, actualSlot);
        }

        [Fact]

        public void CheckIfCorrect_ArmorType()
        {
            Item armor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorTypes.Plate,
                new HeroAttributes { Strength = 1, Dexterity = 0, Intelligence = 0 });

            ArmorTypes expectedArmorType = ArmorTypes.Plate;
            ArmorTypes actualArmorType = armor.GetArmorType();

            Assert.Equal(expectedArmorType, actualArmorType);
        }

        [Fact]

        public void CheckIfCorrect_Attributes()
        {
            Item armor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorTypes.Plate,
                new HeroAttributes { Strength = 1, Dexterity = 0, Intelligence = 0 });

            HeroAttributes expectedAttributes = new HeroAttributes { Strength = 1, Dexterity = 0, Intelligence = 0 };
            HeroAttributes actualAttributes = armor.GetArmorAttributes();

            Assert.Equivalent(expectedAttributes, actualAttributes);
        }
    }
}
