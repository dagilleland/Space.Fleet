using Enexure.MicroBus;
using ShipSystems.Events.Engineering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipSystem.Engineering.Aggregates
{
    class StarDrive
    {
        #region Constructor and Event Tracking
        public StarDrive(params IEvent[] eventHistory)
        {
            foreach (var e in eventHistory)
                ((dynamic)this).Apply((dynamic)e);
        }

        private void Track<TEvent>(TEvent e, Action<TEvent> applyEvent) where TEvent:IEvent
        {
            applyEvent(e);
            _Changes.Add(e);
        }

        private IList<IEvent> _Changes = new List<IEvent>();
        public IEnumerable<IEvent> Changes { get { return _Changes; } }
        #endregion

        #region StarDrive Behaviours
        public void Start()
        {
            if (Running)
                throw new Exception("StarDrive is already running");
            Track(new EngineStarted(), Apply);
            //_Changes.Add(new EngineStarted());
        }
        public void ShutDown()
        {
            Track(new PowerOffline(), Apply);
            Track(new EngineStopped(), Apply);
        }
        public void BringOnline()
        {
            if (!Running)
                throw new Exception("StarDrive is not running and cannot be brought online");
            Track(new PowerOnline(), Apply);
        }
        #endregion

        #region Aggregate State
        private bool Running;
        #endregion

        #region Apply Events
        private void Apply(EngineStarted e)
        {
            Running = true;
        }
        private void Apply(EngineStopped e)
        {
            Running = false;
        }
        private void Apply(PowerOffline e)
        {

        }
        private void Apply(PowerOnline e)
        {

        }
        #endregion
    }
}
