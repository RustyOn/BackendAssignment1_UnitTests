namespace HeroCreatorTests;
using BackendAssignment1;
using BackendAssignment1.Namespace;

public class HeroCreatorUnitTests
{
    [Theory]
    [InlineData("Steffe")]
    public void CheckIfCorrect_Name(string name)
    {
        Hero wizard = new Wizard(name);
        string expectedName = "Steffe";

        string actualName = wizard.GetName();

        Assert.Equal(expectedName, actualName);
    }

    [Theory]
    [InlineData("Arne")]
    public void CheckIfCorrect_Level(string name)
    {
        Hero wizard = new Wizard(name);

        int expectedLevel = 1;

        int actualLevel = wizard.GetLevel();

        Assert.Equal(expectedLevel, actualLevel);
    }

    [Fact]

    public void CheckIfCorrect_Display()
    {
        Hero wizard = new Wizard("Leonidas");

        string display = "The Wizard Hero Leonidas is level 1 \n" +
                            "Strength: 1 \n" +
                            "Dexterity: 1 \n" +
                            "Intelligence: 8 \n" +
                            "The Wizard does 1 damage!";

        string expectedDisplay = display;
        string actualDisplay = wizard.Display();

        Assert.Equal(expectedDisplay, actualDisplay); 
    }

 
}