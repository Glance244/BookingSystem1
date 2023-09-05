using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem1
{
    class OneWay:Booking
    {
        

        public OneWay(string sClass, int iPassengers, DateTime _depatureDate)
        {
            this.Class = sClass;
            this.numPassengers = iPassengers;
            this.Depature = _depatureDate;
            this.mCostofBooking = CalculateAmount();

        }
        public override string Details()
        {
            return "Class: " + Class + "\nPassengers: " + numPassengers + "\n" +
                "DepatureDate: " + Depature.ToShortDateString() +
                "\nAmount:" + Amount.ToString("C");
        }
    }
}
