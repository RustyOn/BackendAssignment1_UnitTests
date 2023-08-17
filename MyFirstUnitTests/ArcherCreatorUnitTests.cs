namespace HeroCreatorTests;
using BackendAssignment1;

public class ArcherCreatorUnitTests
{
    [Theory]
    [InlineData("Bjornarne")]
    public void CheckIfCorrect_ArcherAttributes(string name)
    {
        Hero archer = new Archer(name);

        HeroAttributes expectedAttributes = new HeroAttributes { Strength = 1, Dexterity = 7, Intelligence = 1 };

        HeroAttributes actualAttributes = archer.GetLevelAttributes();

        Assert.Equivalent(expectedAttributes, actualAttributes);
    }

    [Theory]
    [InlineData("Steffe")]

    public void Archer_CheckLevelUp_CorrectIncrement(string name)
    {
        Hero archer = new Archer(name);
        HeroAttributes expectedAttributesAfterLevelUp = new HeroAttributes { Strength = 2, Dexterity = 12, Intelligence = 2 };

        archer.LevelUp();
        HeroAttributes actualAttributesAfterLevelUp = archer.GetLevelAttributes();

        Assert.Equivalent(expectedAttributesAfterLevelUp, actualAttributesAfterLevelUp);
    }
}