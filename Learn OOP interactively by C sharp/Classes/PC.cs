using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learn_OOP_interactively_by_C_sharp.Enum;

namespace Learn_OOP_interactively_by_C_sharp
{
    class PC : Computer
    {
        protected bool mouse_included;
        protected bool keyboard_included;
        protected bool speaker_included;
        protected bool UPS_included;
        Range_sequence_OOP accessLevel = Range_sequence_OOP.Class;

        public PC()
        {
            
        }
        public PC(string name, string CPU_model, int RAM_size, string HardDisk_size, bool SSD_HardDisk, DateTime manufacturingYear, bool mouse_included, bool keyboard_included, bool speaker_included, bool UPS_included)
        {
            base.name = name;
            base.CPU_model = CPU_model;
            base.RAM_size = RAM_size;
            base.HardDisk_size = HardDisk_size;
            base.SSD_HardDisk = SSD_HardDisk;
            base.manufacturingYear = manufacturingYear;
            this.mouse_included = mouse_included;
            this.keyboard_included = keyboard_included;
            this.speaker_included = speaker_included;
            this.UPS_included = UPS_included;
        }
        public PC(bool mouse_included, bool keyboard_included, bool speaker_included, bool UPS_included)
        {
            this.mouse_included = mouse_included;
            this.keyboard_included = keyboard_included;
            this.speaker_included = speaker_included;
            this.UPS_included = UPS_included;
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
            if (UPS_included)
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
             if(mouse_included && keyboard_included && speaker_included)
            {
                return true;
            }
            return false;

    }

        public override double sellingPrice()
        {
            return 1000;
        }

        public override DateTime warrantyDate()
        {
            return DateTime.Now.AddYears(2);
        }
    }
}
