/* Here we create a TV class that inherits from IElectronic device
 * inherits from IElectronic device and implements the methods descrived there
 * plus has its own property Volume
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10
{
    class Television : IElectronicDevice
    {
        public int Volume { get; set; }

        public void Off()
        {
            Console.WriteLine("The TV is off");
        }

        public void On()
        {
            Console.WriteLine("The TV is on");
        }

        public void VolumeDown()
        {
            if (Volume >= 0)
            {
                Volume--;
               Console.WriteLine($"The TV volume is at {Volume}");
            }
        }

        public void VolumeUp()
        {
            if (Volume <= 100)
            {
                Volume++;
                Console.WriteLine($"The TV volume is at {Volume}");
            }
        }
    }
}
