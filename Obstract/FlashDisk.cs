using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obstract
{
    class FlashDisk : Storage
    {


        public FlashDisk(string name, string model, double speed, double capacity, double Used) : base(name, model, Used, capacity, speed)
        {

        }
        public override double FreeMemory()
        {
            return Capacity - Used;

        }
        public override void Copy(double size)
        {
            if (size >= FreeMemory())
            {
                throw new OutOfMemoryException("Memory is Used ");
            }
            Used += size;
            System.Threading.Thread.Sleep(Calculate(size));
        }
        public override double getCapacity()
        {
            return Capacity;
        }
        public override void PrintDeviceInfo()
        {
            Console.WriteLine("=======Flash Disk=======");
            base.PrintDeviceInfo();

        }

    }
}
