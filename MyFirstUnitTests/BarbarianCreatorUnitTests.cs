namespace HeroCreatorTests;
using BackendAssignment1;

public class BarbarianCreatorUnitTests
{

    [Theory]
    [InlineData("Bjorne")]
    public void CheckIfCorrect_BarbarianAttributes(string name)
    {
        Hero barbarian = new Barbarian(name);

        HeroAttributes expectedAttributes = new HeroAttributes { Strength = 5, Dexterity = 2, Intelligence = 1 };

        HeroAttributes actualAttributes = barbarian.GetLevelAttributes();

        Assert.Equivalent(expectedAttributes, actualAttributes);
    }


    [Theory]
    [InlineData("Steffe")]

    public void Barbarian_CheckLevelUp_CorrectIncrement(string name)
    {
        Hero barbarian = new Barbarian(name);
        HeroAttributes expectedAttributesAfterLevelUp = new HeroAttributes { Strength = 8, Dexterity = 4, Intelligence = 2 };

        barbarian.LevelUp();
        HeroAttributes actualAttributesAfterLevelUp = barbarian.GetLevelAttributes();

        Assert.Equivalent(expectedAttributesAfterLevelUp, actualAttributesAfterLevelUp);
    }

}