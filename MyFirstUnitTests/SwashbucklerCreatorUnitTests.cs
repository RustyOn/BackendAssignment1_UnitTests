namespace HeroCreatorTests;
using BackendAssignment1;

public class SwashbucklerCreatorUnitTests
{
 

    [Theory]
    [InlineData("Bjorner")]
    public void CheckIfCorrect_SwashbucklerAttributes(string name)
    {
        Hero swashbuckler = new Swashbuckler(name);

        HeroAttributes expectedAttributes = new HeroAttributes { Strength = 2, Dexterity = 6, Intelligence = 1 };

        HeroAttributes actualAttributes = swashbuckler.GetLevelAttributes();

        Assert.Equivalent(expectedAttributes, actualAttributes);
    }


    [Theory]
    [InlineData("Steffe")]

    public void Swashbuckler_CheckLevelUp_CorrectIncrement(string name)
    {
        Hero swashbuckler = new Swashbuckler(name);
        HeroAttributes expectedAttributesAfterLevelUp = new HeroAttributes { Strength = 3, Dexterity = 10, Intelligence = 2 };

        swashbuckler.LevelUp();
        HeroAttributes actualAttributesAfterLevelUp = swashbuckler.GetLevelAttributes();

        Assert.Equivalent(expectedAttributesAfterLevelUp, actualAttributesAfterLevelUp);
    }


}