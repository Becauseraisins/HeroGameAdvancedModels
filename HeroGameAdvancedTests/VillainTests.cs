using System;
using Xunit;
using HeroGameAdvancedLib;
namespace HeroGameAdvancedTests
{        
    public class VillainTests
    {   Villain villain1 = new Villain(1,"v1",100);
        [Theory]
        [InlineData(100,0)]
        [InlineData(99999,0)]
        [InlineData(69,31)]
        [InlineData(1,99)]
        [InlineData(-1,101)]
        public void Test1(int input, int expectedHp)
        {
            villain1.Damage(input);
            Assert.Equal(expectedHp,villain1.Hitpoints);
        }
    }

}
