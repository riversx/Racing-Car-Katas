using System;
using Xunit;

namespace TDDMicroExercises.TirePressureMonitoringSystem
{
    public class AlarmTest
    {
        [Fact]
        public void Foo() 
        {
            Alarm alarm = new Alarm();
            Assert.Equal(false, alarm.AlarmOn);
        }
    }
}
