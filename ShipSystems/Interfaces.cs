using Enexure.MicroBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipSystems
{
    public interface IInterface
    {
        void Accept(ICommand command);

    }
    public interface IStatus
    {

    }

    // TODO: Move to a more "neutral" and "global" assembly (rather than this one that is focused on Domain Commands/Events)
    public interface IEventStore<TKey>
    {
        IEnumerable<IEvent> LoadEventStream(TKey key);
        void AppendToStream(TKey key, IList<IEvent> events);
    }
}
