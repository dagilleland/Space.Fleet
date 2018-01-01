using Enexure.MicroBus;
using ShipSystem.Engineering.Aggregates;
using ShipSystems;
using ShipSystems.Commands.Engineering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipSystem.Engineering.CommandHandlers
{

    public class StarDriveCommandHandler // TODO: Look for a better name....
        : ICommandHandler<StartEngine>
    {
        private readonly IMicroBus _Publisher;
        private readonly IEventStore<Guid> _Store;
        public StarDriveCommandHandler(IMicroBus eventPublisher, IEventStore<Guid> eventStore) // TODO: params: IMicroBus, IEventStore
        {
            _Publisher = eventPublisher;

        }

        private void Update(Guid aggregateId, Action<StarDrive> execute)
        {
            // TODO: 1) Load event stream from the store (Read db)
            var eventHistory = new List<IEvent>(); // = _Store.LoadEventStream(aggregateId);
            // 2) Create new aggregate from the history
            var ar = new StarDrive(eventHistory.ToArray());
            // 3) Execute delegated action
            execute(ar);
            // TODO: 4) Append resulting changes to the event stream store (Write db)
            // _Store.AppendToStream(id, ar.Changes); // stream.Version, ar.Changes);
            // 5) Publish the changes through the IMicroBus
            foreach (var change in ar.Changes)
                _Publisher.PublishAsync(change);
        }

        public Task Handle(StartEngine command)
        {
            Update(command.Id, a => a.Start());
            return Task.CompletedTask;
        }
    }
}
