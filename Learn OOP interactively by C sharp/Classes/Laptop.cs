using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learn_OOP_interactively_by_C_sharp.Enum;

namespace Learn_OOP_interactively_by_C_sharp
{

    class Laptop : Computer
    {
        protected double laptopWeight;
        protected double screenSize;
        protected double battaryHours;
        protected bool SupportTouchScreen;
        Range_sequence_OOP accessLevel = Range_sequence_OOP.Class;

        public Laptop(){

    }
        public Laptop(string name, string CPU_model, int RAM_size, string HardDisk_size, bool SSD_HardDisk, double laptopWeight, double screenSize, double battaryHours, bool SupportTouchScreen)
        {
            base.name = name;
            base.CPU_model = CPU_model;
            base.RAM_size = RAM_size;
            base.HardDisk_size = HardDisk_size;
            base.SSD_HardDisk = SSD_HardDisk;
            this.laptopWeight = laptopWeight;
            this.screenSize = screenSize;
            this.battaryHours = battaryHours;
            this.SupportTouchScreen = SupportTouchScreen;
        }
        public Laptop(double laptopWeight, double screenSize, double battaryHours, bool SupportTouchScreen)
        {
            this.laptopWeight = laptopWeight;
            this.screenSize = screenSize;
            this.battaryHours = battaryHours;
            this.SupportTouchScreen = SupportTouchScreen;
        }

        public override double maintenancePrice()
        {
            double maintenancePriceValue = 0;
            if (manufacturingYear < DateTime.Now)
            {
                maintenancePriceValue = maintenancePriceValue + 120;
            }
            else
            {
                maintenancePriceValue = maintenancePriceValue + 200;

            }
            if (SSD_HardDisk)
            {
                maintenancePriceValue = maintenancePriceValue + 20;

            }
            else
            {
                maintenancePriceValue = maintenancePriceValue + 80;

            }

            return maintenancePriceValue;
        }

        public override bool saleable()
        {
            if (RAM_size > 8 && SupportTouchScreen )
            {
                return true;
            }
            return false;

        }

        public override double sellingPrice()
        {
            return 1500;
        }

        public override DateTime warrantyDate()
        {
            return DateTime.Now.AddYears(3);
        }
    }
}
