using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learn_OOP_interactively_by_C_sharp.Enum;


namespace Learn_OOP_interactively_by_C_sharp
{
    abstract class Car : Maintenance, Sale
    {
        protected string name;
        protected string color;
        protected double price;
        protected int maxSpeed;
        protected DateTime manufacturingYear;

        Range_sequence_OOP accessLevel = Range_sequence_OOP.Abstract;



        abstract public double maintenancePrice();

        abstract public bool saleable();

        abstract public double sellingPrice();

        abstract public DateTime warrantyDate();
    }
}
