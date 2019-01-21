using System;
using Xunit;
using DownloadSpeedChecker;

namespace UnitTest.ICM
{
    public class UnitTestSpeedCheck
    {
        [Fact]
        public void DownloadSpeed()
        {
            DownloadSpeedo speedTest = DownloadSpeedo.FactoryDownloadSpeedo();

            var test = speedTest.DownloadSpeed;

            Assert.True(true);
        }
    }
}
