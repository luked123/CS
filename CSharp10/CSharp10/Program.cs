/* Luke Donnelly
 * C# Pt 10
 * Covers Interfaces (Class that only contains abstract methods)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehichle buick = new Vehichle("Buick", 4, 160);

            if(buick is IDrivable)
            {
                buick.Move();
                buick.Stop();
            }
            else
            {
                Console.WriteLine("The {0} can't be driven", buick.Brand);
            }

            IElectronicDevice TV = TVRemote.GetDevice();

            PowerButton powBut = new PowerButton(TV);
            powBut.Execute();
            powBut.Undo();

            VolumeButton volBut = new VolumeButton(TV);
            volBut.Execute();
            volBut.Undo();

            Console.ReadLine();
        }
    }
}
