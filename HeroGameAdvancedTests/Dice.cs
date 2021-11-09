using System;
using Xunit;
using HeroGameAdvancedLib;
namespace HeroGameAdvancedTests
{        
    public class DiceTests
    {   Dice dice1;
        Dice Dice2;
        public DiceTests(){
            this.Dice2 = new Dice(1,3);
        }
        [Theory]
        [InlineData(1,1)]
        [InlineData(10,10)]
        [InlineData(1,2)]
        [InlineData(100,1000)]
        public void Dicetest1(int mindamage, int maxdamage)
        {   this.dice1 = new Dice(mindamage,maxdamage);
            Assert.True(dice1.Roll() >= mindamage);
            Assert.True(dice1.Roll() <= maxdamage);
        }   
        [Theory]
        [InlineData(2)]
        public void DiceTest2(int expected){
            Assert.Equal(expected,Dice2.Roll());
        }
    }

}
