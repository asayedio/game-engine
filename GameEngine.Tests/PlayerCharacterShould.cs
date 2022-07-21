using System;
using Xunit;

namespace GameEngine.Tests
{
    public class PlayerCharacterShould
    {
        [Fact]
        public void BeInexperiencedWhenNew()
        {
            PlayerCharacter sut = new PlayerCharacter();

            Assert.True(sut.IsNoob);
        }

        [Fact]
        public void CalculateFullName()
        {
            PlayerCharacter sut = new PlayerCharacter();

            sut.FirstName = "Ahmed";

            sut.LastName = "Sayed";

            Assert.Equal("Ahmed Sayed", sut.FullName);
        }

        [Fact]
        public void HaveFullNameStartingWithFirstName()
        {
            PlayerCharacter sut = new PlayerCharacter();

            sut.FirstName = "Ahmed";

            sut.LastName = "Sayed";

            Assert.StartsWith("Ahmed", sut.FullName);
        }

        [Fact]
        public void HaveFullNameEndingWithLastName()
        {
            PlayerCharacter sut = new PlayerCharacter();

            sut.FirstName = "Ahmed";

            sut.LastName = "Sayed";

            Assert.EndsWith("Sayed", sut.FullName);
        }

        [Fact]
        public void CalculateFullName_IgnoreCaseAssertExample()
        {
            PlayerCharacter sut = new PlayerCharacter();

            sut.FirstName = "AHMED";
            sut.LastName = "SAYED";

            Assert.Equal("Ahmed Sayed", sut.FullName, ignoreCase: true);
        }

        [Fact]
        public void CalculateFullName_SubstringAssertExample()
        {
            PlayerCharacter sut = new PlayerCharacter();

            sut.FirstName = "Ahmed";
            sut.LastName = "Sayed";

            Assert.Contains("ed Sa", sut.FullName);
        }

        [Fact]
        public void CalculateFullNameWithTitleCase()
        {
            PlayerCharacter sut = new PlayerCharacter();

            sut.FirstName = "Ahmed";
            sut.LastName = "Sayed";

            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", sut.FullName);
        }

    }
}
