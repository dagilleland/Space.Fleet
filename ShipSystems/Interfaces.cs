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
}
