using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Models
{
   public class HotelReservation
    {
        public string Name { get; }
        public int NumberOfNights { get; }
        public override string ToString()
        {
            return "Reservation: " + Name + " " + EstimatedTotal;
        }

        public double EstimatedTotal //number of nights times a daily rate of $59.99.
        {
            get
            {
                double estTotal=NumberOfNights * 59.99;
                return estTotal;
            }
            
        }

        public HotelReservation(string name, int numberOfNights)
        {
            Name = name;
            NumberOfNights = numberOfNights;
        }


        public double ActualTotal(bool requiresCleaning, bool usedMinibar)
        {
            HotelReservation hotelRes = new HotelReservation("Test", 3);
            double useBarFee = 12.99;
            double cleaningFee = 34.99;
            double totalFee = 0;

            if (requiresCleaning == true && usedMinibar == true)
            {
                totalFee = (cleaningFee * 2) + useBarFee;
                totalFee += hotelRes.EstimatedTotal;
                 return totalFee;
            }
            else if (requiresCleaning)
            {
                totalFee += cleaningFee;
                totalFee += hotelRes.EstimatedTotal;
                return totalFee;
            }
            else if (usedMinibar)
            {
                totalFee += useBarFee;
                totalFee += hotelRes.EstimatedTotal;

                return totalFee;
            }
            else
            {
                totalFee += hotelRes.EstimatedTotal;
                return totalFee;
            }

            //return totalFee;
        }
    }
}
