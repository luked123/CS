/* Another interface that simulates pressing a button */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10
{
    interface ICommand
    {
        void Execute();
        void Undo();
    }
}
