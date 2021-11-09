using System;
using Xunit;
using HeroGameAdvancedLib;
namespace HeroGameAdvancedTests
{        
    public class DiceTests
    {   Dice dice1;
        [Theory]
        [InlineData(1,1)]
        [InlineData(10,10)]
        [InlineData(10,1)]
        [InlineData(100,1000)]
        public void Test1(int mindamage, int maxdamage)
        {   this.dice1 = new Dice(mindamage,maxdamage);
            Assert.True( dice1.Roll() >= mindamage);
            Assert.True(dice1.Roll() <= maxdamage);
        }   
    }

}
