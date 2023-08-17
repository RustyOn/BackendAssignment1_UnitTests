namespace HeroCreatorTests;
using BackendAssignment1;

public class WizardCreatorUnitTests
{


    [Theory]
    [InlineData("Bjorn")]
    public void CheckIfCorrect_WizardAttributes(string name)
    {
        Hero wizard = new Wizard(name);

        HeroAttributes expectedAttributes = new HeroAttributes { Strength = 1, Dexterity = 1, Intelligence = 8 };

        HeroAttributes actualAttributes = wizard.GetLevelAttributes();

        Assert.Equivalent(expectedAttributes, actualAttributes);
    }

    [Theory]
    [InlineData("Steffe")]

    public void Wizard_CheckLevelUp_CorrectIncrement(string name)
    {
        Hero wizard = new Wizard(name);
        HeroAttributes expectedAttributesAfterLevelUp = new HeroAttributes { Strength = 2, Dexterity = 2, Intelligence = 13 };

        wizard.LevelUp();
        HeroAttributes actualAttributesAfterLevelUp = wizard.GetLevelAttributes();

        Assert.Equivalent(expectedAttributesAfterLevelUp, actualAttributesAfterLevelUp);
    }
}