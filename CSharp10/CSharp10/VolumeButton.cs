/* Represents a button that inherits from the interface ICommand
 * Implements methods that tell the device what to do if the button is pressed
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10
{
    class VolumeButton : ICommand
    {
        public IElectronicDevice device;

        public VolumeButton(IElectronicDevice device)
        {
            this.device = device;
        }

        public void Execute()
        {
            device.VolumeUp();
        }

        public void Undo()
        {
            device.VolumeDown();
        }
    }
}
