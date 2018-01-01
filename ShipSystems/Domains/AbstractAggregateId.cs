using System;
using System.Linq;

namespace ShipSystems.Domains
{
    // TODO: Docs: In b) below, express the idea that an AR has an ID property whose base class is the AbstractAggregateId
    /// <summary>
    /// Represents an Aggregate Root in the ShipSystems domain. This class wraps a Guid as the identifier.
    /// </summary>
    /// <remarks>
    /// Intended for use as:
    /// a) base class for Commands and Events (to identify their aggregate)
    /// b) 
    /// </remarks>
    public abstract class AbstractAggregateId
    {
        public AbstractAggregateId(Guid id)
        {
            if (Guid.Empty.Equals(id))
                throw new ArgumentException("Invalid Aggregate Identifier");
        }
        public Guid Id { get; protected set; }
    }
}
