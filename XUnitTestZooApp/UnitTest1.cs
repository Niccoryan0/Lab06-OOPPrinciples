using System;
using Xunit;
using Lab06_OOPPrinciples.Classes;

namespace XUnitTestZooApp
{
    public class UnitTest1
    {
        [Fact]
        public void CrocodileCanInheritSleep()
        {
            Crocodile croc = new Crocodile("large", true, 4, "green");
            bool result = croc.ToggleSleep(true);
            Assert.False(result);
        }

        [Fact]
        public void GiraffeCanInheritSleep()
        {
            Giraffe giraffe = new Giraffe(6, true, 8, "yellow");
            bool result = giraffe.ToggleSleep(false);
            Assert.True(result);
        }

        [Fact]
        public void GrizzlyBearCanInheritSleep()
        {
            GrizzlyBear grizzly = new GrizzlyBear(true, 1000, 6, "brown", true);
            bool result = grizzly.ToggleSleep(false);
            Assert.True(result);
        }

        [Fact]
        public void LionCanInheritSleep()
        {
            Lion lion = new Lion(true, 8, 3, "tan", true);
            bool result = lion.ToggleSleep(false);
            Assert.True(result);
        }

        [Fact]
        public void SlothCanInheritSleep()
        {
            Sloth sloth = new Sloth(500, "slow", 10, "grey");
            bool result = sloth.ToggleSleep(false);
            Assert.True(result);
        }

        [Fact]
        public void SnakeCanInheritSleep()
        {
            Snake cobra = new Snake(11, "highly venomous", 3, "black");
            bool result = cobra.ToggleSleep(false);
            Assert.True(result);
        }

        [Fact]
        public void LionCanSweat()
        {
            Lion lion = new Lion(true, 8, 3, "tan", true);
            string result = lion.Sweat();
            Assert.Equal("I am sweaty", result);
        }
    }
}
