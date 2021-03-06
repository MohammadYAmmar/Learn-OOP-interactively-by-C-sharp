using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learn_OOP_interactively_by_C_sharp.Enum;


namespace Learn_OOP_interactively_by_C_sharp
{
    abstract class ComputerISale: Maintenance
    {
        protected string name;
        protected string CPU_model;
        protected int RAM_size;
        protected string HardDisk_size;
        protected bool SSD_HardDisk;
        protected DateTime manufacturingYear;

        public Range_sequence_OOP accessLevel = Range_sequence_OOP.Abstract;



        abstract public double maintenancePrice();

        abstract public bool saleable();

        abstract public double sellingPrice();

        abstract public DateTime warrantyDate();
    }
}
