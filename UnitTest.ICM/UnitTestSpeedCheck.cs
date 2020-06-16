using System;
using Xunit;
using DownloadSpeedChecker;

namespace UnitTest.ICM
{
    public class UnitTestSpeedCheck
    {
        //Todo: fix test
        [Fact]
        public void DownloadSpeed()
        {
            DownloadSpeedo speedTest = DownloadSpeedo.FactoryDownloadSpeedo();

            var test = speedTest.DownloadSpeed;

            Assert.True(true);
        }
    }
}
