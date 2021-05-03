using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obstract
{
    public static class Run
    {
        public static void Start()
        {
            HDD hdd = new HDD("HDD Super", "Samsung", 1, 1024 * 1024, 0);
            DVD_Disk dvd = new DVD_Disk("DVD Super", "Asus", 0.5, 1000, 0);
            FlashDisk flash = new FlashDisk("Flash Super", "Xiaomi", 0.5, 1000, 0);
            Storage[] storages = new Storage[3] { hdd, dvd, flash };
            Console.WriteLine("Enter Data Size with GB");
            double size = double.Parse(Console.ReadLine());
            int select = 0;
            int selecta = 0;
            void wrongChoose()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Choose");
                System.Threading.Thread.Sleep(2000);
                Console.ResetColor();
            }
            void EnterGb()
            {
                Console.Clear();
                Console.WriteLine("Enter Data Size with GB");
                size = double.Parse(Console.ReadLine());
                Again();

            }
            void CopyData()
            {
                storages[select - 1].Copy(size);
                storages[select - 1].TransferTime(size);
                Console.WriteLine("1)Back");
                selecta = int.Parse(Console.ReadLine());
                if (selecta == 1)
                {
                    Console.Clear();
                    Select();
                }
                else
                {
                    wrongChoose();
                    CopyData();
                }
            }
            void FreeMemory()
            {
                Console.WriteLine($"Free Memory : {storages[select - 1].FreeMemory()}");
                Console.WriteLine("1)Back");
                selecta = int.Parse(Console.ReadLine());
                if (selecta == 1)
                {
                    Console.Clear();
                    Select();
                }
                else
                {
                    wrongChoose();
                    FreeMemory();
                }
            }
            void PrintDeviceInfo()
            {
                storages[select - 1].PrintDeviceInfo();
                Console.WriteLine("1)Back");
                selecta = int.Parse(Console.ReadLine());
                if (selecta == 1)
                {
                    Console.Clear();
                    Select();
                }
                else
                {

                    wrongChoose();
                    PrintDeviceInfo();
                }
            }
            void ShowStorage()
            {
                Console.WriteLine($"Total Storage : { storages[select - 1].getCapacity()}");
                Console.WriteLine("1)Back");
                selecta = int.Parse(Console.ReadLine());
                if (selecta == 1)
                {
                    Console.Clear();
                    Select();
                }
                else
                {
                    wrongChoose();
                    ShowStorage();
                }
            }
            void Menu()
            {
                Console.Clear();
                Console.WriteLine("1)HDD");
                Console.WriteLine("2)DVD");
                Console.WriteLine("3)Flash");
                Console.WriteLine("4)Back");
                Console.Write("Your Select : ");
            }
            void Select()
            {

                Console.Clear();
                Console.WriteLine("1)Copy Data ");
                Console.WriteLine("2)Show Free Memory ");
                Console.WriteLine("3)Show Device Info");
                Console.WriteLine("4)Show Storage ");
                Console.WriteLine("5)Back");
                int select2 = int.Parse(Console.ReadLine());
                if (select2 == 1)
                {
                    CopyData();
                }
                else if (select2 == 2)
                {
                    FreeMemory();
                }
                else if (select2 == 3)
                {
                    PrintDeviceInfo();
                }
                else if (select2 == 4)
                {
                    ShowStorage();
                }
                else if (select2 == 5)
                {
                    Again();
                }
                else
                {
                    wrongChoose();
                    Select();
                }

            }
            try
            {
                Menu();
                select = int.Parse(Console.ReadLine());
                if (select == 1)
                {
                    Select();
                }
                else if (select == 2)
                {
                    Select();
                }
                else if (select == 3)
                {
                    Select();
                }
                else if (select == 4)
                {
                    Console.Clear();
                    EnterGb();
                }
                else
                {
                    wrongChoose();
                    Again();
                }
            }
            catch (OutOfMemoryException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error : {ex.Message}");
                System.Threading.Thread.Sleep(2000);
                Console.ResetColor();

                Again();
            }

            void Again()
            {
                Menu();
                select = int.Parse(Console.ReadLine());
                if (select == 1)
                {
                    Select();
                }
                else if (select == 2)
                {
                    Select();
                }
                else if (select == 3)
                {
                    Select();
                }
                else if (select == 4)
                {
                    EnterGb();
                }
                else
                {
                    wrongChoose();
                    Again();
                }
            }
        }
    }
}
