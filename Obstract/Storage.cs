using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obstract
{
    abstract class Storage
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public double Used { get; set; }
        public double Capacity { get; set; }
        public double Speed { get; set; }

        public Storage(string name, string model, double used, double capacity, double speed)
        {
            Name = name;
            Model = model;
            Used = used;
            Capacity = capacity;
            Speed = speed;
        }
        public abstract double FreeMemory();
        public abstract void Copy(double size);
        protected TimeSpan Calculate(double dataSize)
        {
            var t = dataSize / Speed;
            return TimeSpan.FromSeconds(t);
        }
        public void TransferTime(double size)
        {
            var Time = Calculate(size);
            Console.WriteLine($"Data Transfer Day :{Time.Days} day ,{Time.Hours} hours , {Time.Minutes} minutes , {Time.Seconds} seconds ,{Time.Milliseconds} milliseconds  ");
        }
        public abstract double getCapacity();
        public virtual void PrintDeviceInfo()
        {

            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Model : {Model}");
            Console.WriteLine($"Used : {Used}");
            Console.WriteLine($"Capacity : {Capacity}");
            Console.WriteLine($"Speed : {Speed}");
        }


    }
}
