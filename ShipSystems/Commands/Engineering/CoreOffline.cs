using Enexure.MicroBus;
using ShipSystems.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipSystems.Commands.Engineering
{
    public class StartEngine : AbstractAggregateId, ICommand
    {
        public StartEngine(Guid id) : base(id)
        {

        }
    }
    public class TakeEngineOffline : ICommand
    {
        
    }
    public class ShutDownEngine : ICommand
    {
        
    }
    public class EngageStarDrive : ICommand
    {
        
    }
    public class DisengageStarDrive : ICommand
    {
        
    }
    public class RoutePower : ICommand
    {
        
    }
}
