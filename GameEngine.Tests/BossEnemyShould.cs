using System;
using Xunit.Abstractions;

namespace GameEngine.Tests
{
    [Trait("Category", "Boss")]
    public class BossEnemyShould
    {
        private readonly ITestOutputHelper _output;

        public BossEnemyShould(ITestOutputHelper output) => _output = output;

        [Fact]
        public void HaveCorrectPower()
        {
            _output.WriteLine("Creating Boss Enemy");
            BossEnemy sut = new BossEnemy();

            Assert.Equal(166.667, sut.TotalSpecialAttackPower, 3);
        }

    }
}
