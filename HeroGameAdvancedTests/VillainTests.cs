using System;
using Xunit;
using HeroGameAdvancedLib;
namespace HeroGameAdvancedTests
{        
    public class VillainTests
    {   Villain villain1;
        Villain Villain2;
        public VillainTests(){
        this.villain1 = new Villain(1,"v1",100); 
        this.Villain2 = new Villain(2,"v2",0);
        }
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
        [Theory]
        [InlineData(1,0)]
                public void Test2(int input, int expectedHp)
        {
            Villain2.Damage(input);
            Assert.Equal(expectedHp,Villain2.Hitpoints);
        }
    }

}
