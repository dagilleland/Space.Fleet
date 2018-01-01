using ShipSystem.Engineering.Aggregates;
using ShipSystems.Events.Engineering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ShipSystem.Engineering.Specs.Aggregates
{
    public class StarDrive_Specs
    {
        [Fact]
        public void Should_Start_Engine()
        {
            var sut = new StarDrive();
            sut.Start();
            Assert.Single(sut.Changes);
            var actual = sut.Changes.FirstOrDefault() as EngineStarted;
            Assert.NotNull(actual);
        }

        [Fact]
        public void Should_Not_Start_Engine_When_Already_Started()
        {
            var sut = new StarDrive(new EngineStarted());
            Assert.Throws<Exception>(() => sut.Start());
        }

        [Fact]
        public void Should_Stop_Engine_When_Started()
        {
            var sut = new StarDrive(new EngineStarted());
            sut.ShutDown();
            Assert.Single(sut.Changes.Where(x=>x is EngineStopped));
            var actual = sut.Changes.FirstOrDefault(x => x is EngineStopped) as EngineStopped;
            Assert.NotNull(actual);            
        }

        [Fact]
        public void Should_Bring_Engine_Online()
        {
            var sut = new StarDrive(new EngineStarted());
            sut.BringOnline();
            Assert.Single(sut.Changes);
            var actual = sut.Changes.FirstOrDefault() as PowerOnline;
            Assert.NotNull(actual);
        }
    }
}
