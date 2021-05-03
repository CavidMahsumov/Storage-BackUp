using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obstract
{
    class DVD_Disk : Storage
    {

        public DVD_Disk(string name, string model, double speed, double capacity, double Used) : base(name, model, Used, capacity, speed)
        {

        }
        public override double FreeMemory()
        {
            return Capacity - Used;
        }
        public override double getCapacity()
        {
            return Capacity;
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
        public override void PrintDeviceInfo()
        {
            Console.WriteLine("=====DVDDISK=====");
            base.PrintDeviceInfo();
            ;
        }

    }
}
