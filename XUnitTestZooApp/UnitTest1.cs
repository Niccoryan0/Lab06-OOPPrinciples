using System;
using Xunit;
using Lab06_OOPPrinciples.Classes;
using System.Diagnostics.Contracts;

namespace XUnitTestZooApp
{
    public class UnitTest1
    {
        [Fact]
        public void HorseCanInheritSleep()
        {
            Horse horse = new Horse(6, true, 8, "yellow");
            string result = horse.Sleep();
            Assert.Equal("I sleep when I'm tired because I'm warm blooded", result);
        }

        [Fact]
        public void GrizzlyBearCanInheritSleep()
        {
            GrizzlyBear grizzly = new GrizzlyBear(true, 1000, 6, "brown", true);
            string result = grizzly.Sleep();
            Assert.Equal("I sleep when I'm tired because I'm warm blooded", result);
        }

        [Fact]
        public void LionCanInheritSleep()
        {
            Lion lion = new Lion(true, 8, 3, "tan", true);
            string result = lion.Sleep();
            Assert.Equal("I sleep when I'm tired because I'm warm blooded", result);
        }

        [Fact]
        public void SlothCanInheritSleep()
        {
            Sloth sloth = new Sloth(500, "slow", 10, "grey");
            string result = sloth.Sleep();
            Assert.Equal("I sleep when I'm tired because I'm warm blooded", result);
        }

        [Fact]
        public void CrocodileCanInheritSleep()
        {
            Crocodile croc = new Crocodile("large", true, 4, "green");
            string result = croc.Sleep();
            Assert.Equal("I sleep when I'm cold because I'm cold blooded", result);
        }

        [Fact]
        public void LionCanInheritSweat()
        {
            Lion lion = new Lion(true, 8, 3, "tan", true);
            string result = lion.Sweat();
            Assert.Equal("Carnivores don't sweat", result);
        }

        [Fact]
        public void SnakeSleepPolymorph()
        {
            Snake cobra = new Snake(11, "highly venomous", 3, "black");
            string result = cobra.Sleep();
            Assert.Equal("I sleep when I'm cold because I'm cold blooded and I curl up really tight.", result);
        }

        [Fact]
        public void SnakeCanBask()
        {
            Snake cobra = new Snake(11, "highly venomous", 3, "black");
            string result = cobra.Bask();
            Assert.Equal("Baskin' in the sun", result);
        }

        [Fact]
        public void SlothSweatOverride()
        {
            Sloth sloth = new Sloth(500, "slow", 10, "grey");
            string result = sloth.Sweat();
            Assert.Equal("I'm a sloth and we can't sweat", result);
        }

        [Fact]
        public void HorseSweatOverride()
        {
            Horse horse = new Horse(6, true, 8, "yellow");
            string result = horse.Sweat();
            Assert.Equal("I'm a horse and we can sweat", result);
        }

        [Fact]
        public void LionCanInheritNumberOfLegs()
        {
            Lion lion = new Lion(true, 8, 3, "tan", true);
            Assert.Equal(4, lion.NumberOfLegs);
        }

        [Fact]
        public void SlothCanOverrideNumberOfLegs()
        {
            Sloth sloth = new Sloth(500, "slow", 10, "grey");
            Assert.Equal(2, sloth.NumberOfLegs);
        }


    }
}
