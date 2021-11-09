using System;
using Xunit;
using HeroGameAdvancedLib;
namespace HeroGameAdvancedTests
{
    public class HeroTests
    {
        Dice OneDamage;
        Hero Hero1;
        Villain Villain1;

        public HeroTests(){
        this.OneDamage = new Dice(1,1);
        this.Hero1 = new Hero(1, "H1", OneDamage, 100);
        this.Villain1 = new Villain(1, "v1", 10);
        }
        [Theory]
        [InlineData(1, 99,1)]
        [InlineData(101, 100,-1)]
        [InlineData(10,90,10)]
        [InlineData(0,100,0)]
        [InlineData(1000,100,-1)]
        public void AttackTest(int attacks, int expectedUses, int expectedDamage)
        {   
            int Damage = Hero1.Attack(attacks);
            Assert.Equal(expectedUses,Hero1.Uses);
            Assert.Equal(Damage, expectedDamage);
        }
    }
}
