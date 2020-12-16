using System;
using System.IO;
using Assessment.Models;
using System.Collections.Generic;
using System.Linq;

namespace Assessment
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            
            string fileName = "HotelInput.csv";
            using (StreamReader sr = new StreamReader(fileName))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] splitLine = line.Split(",");
                    List<HotelReservation> hotelList = new List<HotelReservation>();
                    hotelList.Add(new HotelReservation(splitLine[0], int.Parse(splitLine[1])));
                }
            }
        }

    }
}
