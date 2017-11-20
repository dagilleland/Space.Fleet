using Enexure.MicroBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipSystems.Events.AllSystems
{
    public class SystemsDamaged : IEvent
    {
    }
    public class DamageRepaired : IEvent
    {
        
    }
    public class RepairCrewDispatched : IEvent
    {
        
    }
    public class SystemsDisabled : IEvent
    {
        
    }
    public class SystemsRestored : IEvent
    {
        
    }
    public class SystemsDestroyed : IEvent
    {
        
    }
}
