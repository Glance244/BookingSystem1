using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem1
{
    class Return : Booking
    {
        private DateTime dtReturn;
        public Return(string sClass, int iPassengers, DateTime _depatureDate, DateTime _Return)
        {
            this.Class = sClass;
            this.numPassengers = iPassengers;
            this.Depature = _depatureDate;
            this.tReturn = _Return;
            this.mCostofBooking = CalculateAmount();

        }

        public DateTime tReturn
        {
            get { return dtReturn; }
            set
            {
                if (value >= Depature)
                    dtReturn = value;
                else
                    Depature = dtReturn;
            }
        }
        protected override Decimal CalculateAmount()
        {
            return base.CalculateAmount() * 2;
        }
        public override string Details()
        {
            return "Class: " + Class + "\nPassengers: " + numPassengers + "\n" +
                "DepatureDate: " + Depature.ToShortDateString() + "\nReturn: "+tReturn.ToShortDateString() 
                   + "\nAmount:" + Amount.ToString("C");
        }


    }
}
