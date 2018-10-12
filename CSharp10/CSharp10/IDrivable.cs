/* First interface used */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10
{
    // Common to name interfaces adjectives as the affect nouns and are abstract
    interface IDrivable
    {
        // Interfaces can have properties
        int Wheels { get; set; }
        double Speed { get; set; }

        // Here are the abstract methods a class must implement if inheirited from IDrivable
        void Move();
        void Stop();
    }
}
