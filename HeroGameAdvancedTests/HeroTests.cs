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
        [InlineData(1, 99, 9)]
        [InlineData(101, -1, 0)]
        [InlineData(102,-1,0)]
        [InlineData(0,100,10)]
        [InlineData(1000,-1,0)]
        public void AttackTest(int attacks, int expectedUses, int expectedHitPoints)
        {   
 
            Villain1.Damage(Hero1.Attack(attacks));
            Assert.Equal(expectedHitPoints,Villain1.Hitpoints);
            Assert.Equal(expectedUses,Hero1.Uses);
        }
    }
}
