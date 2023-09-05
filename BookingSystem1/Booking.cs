using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem1
{
    abstract class Booking
    {
        public string Class { get; set; }
        public int numPassengers { get; set; }
        protected decimal mCostofBooking;
        private DateTime mDepature;

        public decimal Amount
        {
            get { return mCostofBooking; }
        }
        public DateTime Depature
        {
            get { return mDepature; }
            set { if (value>= DateTime.Now)
                    mDepature = value;
                else
                    mDepature = DateTime.Now;
                
            }
            
        }
        protected virtual decimal CalculateAmount()
        { 
            if (Class=="First")
                return 80000 * numPassengers;
            else if (Class=="Business")
                return 5000 * numPassengers;
            else
                return 1500 * numPassengers;

        }
        public abstract string Details();
    }
}
